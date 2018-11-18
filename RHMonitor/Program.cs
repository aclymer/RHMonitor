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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new RPCClient()));
        }
    }

    public class RPCClient
    {
        public static Dictionary<string, string[]> clients = new Dictionary<string, string[]>();

        public RPCClient()
        {
            StartListener();
            System.Threading.Timer tm = new System.Threading.Timer(TimerCallback);
            tm.Change(0, 10000);
        }

        internal Dictionary<string, string[]> GetDict()
        {
            return clients;
        }

        private void TimerCallback(object state)
        {
            string localIP = GetLocalIP().ToString();

            if (!String.IsNullOrEmpty(localIP))
            {
                string[] gatewayIP = localIP.Split('.');
                //host is active
                for (int i = 1; i < 255; i++)
                {
                    ConnectAsTcpClient(gatewayIP[0] + "." + gatewayIP[1] + "." + gatewayIP[2] + "." + i.ToString());
                }
            }
        }

        static IPAddress GetLocalIP()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("1.1.1.1", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address;
            }
        }

        private static readonly string ClientRequestString = " ";
        private static readonly byte[] ClientRequestBytes = Encoding.UTF8.GetBytes(ClientRequestString);

        private static readonly string ServerResponseString = " ";
        private static readonly byte[] ServerResponseBytes = Encoding.UTF8.GetBytes(ServerResponseString);

        private static async void ConnectAsTcpClient(string address)
        {
            try
            {
                using (var tcpClient = new TcpClient())
                {
                    Console.WriteLine("[Client] Connecting to server");
                    await tcpClient.ConnectAsync(address, 7111);
                    Console.WriteLine("[Client] Connected to server");
                    using (var networkStream = tcpClient.GetStream())
                    {
                        Console.WriteLine("[Client] Writing request {0}", ClientRequestString);
                        await networkStream.WriteAsync(ClientRequestBytes, 0, ClientRequestBytes.Length);

                        var buffer = new byte[512];
                        var byteCount = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                        var response = Encoding.UTF8.GetString(buffer, 0, byteCount);

                        if (!String.IsNullOrEmpty(response))
                            ParseResponse(tcpClient.Client.RemoteEndPoint.ToString(), response);

                        Console.WriteLine("[Client] Server response was {0}", response);
                    }
                }
            }
            catch (System.Net.Sockets.SocketException e)
            {
                e.Equals(e);
                return;
            }
        }

        private static void ParseResponse(string ip, string response)
        {
            string[] args = response.Replace("\"","").Split("{[]},\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            string name = ip.Split(':')[0];

            if (clients.ContainsKey(name))
                clients[name] = args;
            else
                clients.Add(name, args);
        }

        private static async void StartListener()
        {
            var tcpListener = TcpListener.Create(7111);
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
