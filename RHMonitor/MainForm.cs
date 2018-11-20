using System;
using RHMonitor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHMonitor
{
    public partial class MainForm : Form
    {
        //    name = 0,
        //    threads = 1,
        //    speed = 2 | 7,
        //    accepted = 3 | 8,
        //    rejected = 4 | 9,
        //    temp = 5,
        //    fan = 6,
        //    failed = 10,
        //    uptime = 11,
        //    extrapayload = 12,
        //    server = 13,
        //    user = 14,
        //    diff = 15

        delegate void DictArgReturningVoidDelegate(SortedDictionary<string, string[]> text);

        RPCClient rpcclient;
        SortedDictionary<string, string[]> clients;
        List<int> HashRates = new List<int>();

        public MainForm(RPCClient client)
        {
            InitializeComponent();
            rpcclient = client;
            System.Threading.Timer tm = new System.Threading.Timer(TimerCallback);
            tm.Change(0, 1000);
        }

        private void TimerCallback(object state)
        {
            clients = rpcclient.GetDict();
            SetText(clients);
        }

        private void SetText(SortedDictionary<string, string[]> clients)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBoxClients.InvokeRequired)
            {
                DictArgReturningVoidDelegate d = new DictArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { clients });
            }
            else
            {
                int rateSum = 0;
                int threadSum = 0;
                int[] arf = { 0, 0, 0 };
                string[] keys = this.clients.Keys.ToArray();

                for (int i = 0; i < keys.Length; i++)
                {
                    string clientName = keys[i];

                    if (clientName == null)
                        continue;

                    try
                    {
                        var item = new ClientInstance(clientName, this.clients[keys[i]]);

                        foreach (ClientInstance cntrl in listBoxClients.Controls)
                        {
                            if (cntrl.Name == item.Name)
                            {
                                item = cntrl;
                                break;
                            }
                        }

                        if (listBoxClients.Controls.Contains(item))
                            item.SetAllFields(this.clients[keys[i]]);
                        else
                            this.listBoxClients.Controls.Add(item);

                        rateSum += item.GetHashRate();
                        threadSum += item.GetThreads();
                        var temp = item.GetARF();
                        arf = new int[] { arf[0] + temp[0], arf[1] + temp[1], arf[2] + temp[2] };
                    }
                    catch (KeyNotFoundException e)
                    {
                        e.Equals(e);
                        listBoxClients.Controls.RemoveByKey(clientName);
                        continue;
                    }
                }

                if (this.clients.Count < listBoxClients.Controls.Count - 1)
                {
                    ClientInstance client = null;
                    foreach (ClientInstance instance in listBoxClients.Controls)
                    {
                        if (!this.clients.ContainsKey(instance.Name))
                            client = instance;
                    }

                    if (client != null)
                        listBoxClients.Controls.Remove(client);
                }

                HashRates.Add(rateSum);
                totalThreads.Text = threadSum.ToString();
                averageHashRate.Text = String.Format("{0} H/s", GetAverageHashRate());
                acceptedBlocks.Text = String.Format("{0} / {1} / {2}", arf[0], arf[1], arf[2]);
                numberOfClients.Text = String.Format("Clients: {0}", this.clients.Count.ToString());
                listBoxClients.Update();
            }
        }

        private int GetAverageHashRate()
        {
            if (HashRates.Count < 2)
                return HashRates.Sum();

            return HashRates.Sum() / HashRates.Count;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter)
            {
                System.Net.IPAddress ip;

                if (System.Net.IPAddress.TryParse(textBox1.Text, out ip))
                    Program.client.ConnectAsTcpClient(ip.ToString());

                textBox1.Text = "Enter manual IP address here";
                this.SelectNextControl(textBox1, false, true, true, true);
            }
            else if (e.KeyChar == (char)System.ConsoleKey.Escape)
            { 
                textBox1.Text = "Enter manual IP address here";
                this.SelectNextControl(textBox1, false, true, true, true);
            }
            else if (!"0123456789.".ToCharArray().Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Enter manual IP address here";
        }
    }
}
