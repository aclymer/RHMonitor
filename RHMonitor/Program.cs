using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RHMonitor
{
    public static class Program
    {
        public static RPCClient client = new RPCClient();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(client));
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(',') ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");

            dllName = dllName.Replace(".", "_");

            if (dllName.EndsWith("_resources")) return null;

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("RHMonitor.Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());

            byte[] bytes = (byte[])rm.GetObject(dllName);

            if (bytes == null) return null;

            return System.Reflection.Assembly.Load(bytes);
        }
    }

    public class RPCClient
    {
        private string localIP;
        public string DefaultPort { get; set; }
        public static SortedDictionary<string, string[]> clients = new SortedDictionary<string, string[]>(new IPComparer());

        public RPCClient()
        {
            DefaultPort = "7111";
            StartListener(DefaultPort);
            System.Threading.Timer tm = new System.Threading.Timer(TimerCallback);
            tm.Change(0, 10000);
            localIP = GetLocalIP().ToString();
        }

        internal ref SortedDictionary<string, string[]> GetDict()
        {
            return ref clients;
        }

        internal void TimerCallback(object state)
        {
            if (!String.IsNullOrWhiteSpace(localIP))
            {
                string[] gatewayIP = localIP.Split('.');

                //host is active
                for (int i = 0; i < clients.Count; i++)
                {
                    var client = clients.ElementAt(i);
                    ConnectAsTcpClient(client.Key);
                }

                for (int i = 1; i < 255; i++)
                {
                    string address = gatewayIP[0] + "." + gatewayIP[1] + "." + gatewayIP[2] + "." + i.ToString() + ":" + DefaultPort;

                    if (!clients.ContainsKey(address))
                        ConnectAsTcpClient(address);
                }
            }
        }
        
        private IPAddress GetLocalIP()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("1.1.1.1", int.Parse(DefaultPort));
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address;
            }
        }

        private static readonly string ClientRequestString = " ";
        private static readonly byte[] ClientRequestBytes = Encoding.UTF8.GetBytes(ClientRequestString);

        private static readonly string ServerResponseString = " ";
        private static readonly byte[] ServerResponseBytes = Encoding.UTF8.GetBytes(ServerResponseString);
        
        public class IPComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                int temp = 0;
                IPAddress xIP = IPAddress.Parse(x.Split(':')[0]);
                IPAddress yIP = IPAddress.Parse(y.Split(':')[0]);

                if (xIP.Equals(yIP))
                {
                    temp = int.Parse(x.Split(':')[1]).CompareTo(int.Parse(y.Split(':')[1]));
                }
                else
                {
                    int i = 0;
                    var x_array = x.Split(".:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var y_array = y.Split(".:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    while (i < Math.Min(x_array.Length, y_array.Length) && temp == 0)
                    {
                        temp = int.Parse(x_array[i]).CompareTo(int.Parse(y_array[i]));
                        i++;
                    }
                }
                return temp;
            }
        }

        public async void ConnectAsTcpClient(string address)
        {
            try
            {
                using (var tcpClient = new TcpClient() { ReceiveTimeout = 100 })
                {
                    await tcpClient.ConnectAsync(address.Split(':')[0], int.Parse(address.Split(':')[1]));

                    Console.WriteLine("Connected to " + address);

                    using (var networkStream = tcpClient.GetStream())
                    {
                        await networkStream.WriteAsync(ClientRequestBytes, 0, ClientRequestBytes.Length);

                        var buffer = new byte[2048];
                        var byteCount = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                        var response = Encoding.UTF8.GetString(buffer, 0, byteCount);

                        if (String.IsNullOrWhiteSpace(response.Trim()) || !response.Contains("info"))
                        {
                            if (clients.ContainsKey(address))
                                clients.Remove(address);
                        }
                        else
                            ParseResponse(tcpClient.Client.RemoteEndPoint.ToString(), response);

                        Console.WriteLine("Client response was {0}", response);
                    }
                }
            }
            catch (System.Net.Sockets.SocketException e)
            {
                NotConnected(address);
                e.Equals(e);
                return;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.StackTrace, e.Message);
                e.Equals(e);
                return;
            }
        }

        private static void NotConnected(string address)
        {
            lock (clients)
            {
                if (clients.Keys.Contains(address))
                    clients.Remove(address);
            }
        }

        private static void ParseResponse(string address, string response)
        {
            string[] temp = response.Replace("\"", "").Split("[]".ToCharArray());
            int threads = 0;

            foreach (var pair in temp[1].Split("{},\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                if (pair.Contains("threads"))
                    threads += int.Parse(pair.Split(':')[1].Trim());
            }
            string[] args = (String.Format("threads:{0},", threads) + temp[2]).Split("{},\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            
            if (clients.ContainsKey(address))
                clients[address] = args;
            else
                clients.Add(address, args);
        }

        private static async void StartListener(string port)
        {
            var tcpListener = TcpListener.Create(int.Parse(port));
            tcpListener.Start();
            var tcpClient = await tcpListener.AcceptTcpClientAsync();
            Console.WriteLine("[Server] Client has connected");
            using (var networkStream = tcpClient.GetStream())
            {
                var buffer = new byte[512];
                Console.WriteLine("[Server] Reading from client");
                var byteCount = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                var request = Encoding.UTF8.GetString(buffer, 0, byteCount);
                Console.WriteLine("[Server] Client wrote {0}", request);
                await networkStream.WriteAsync(ServerResponseBytes, 0, ServerResponseBytes.Length);
                Console.WriteLine("[Server] Response has been written");
            }
        }
    }
}
