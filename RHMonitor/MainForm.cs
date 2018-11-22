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

        Point scrollPos = new Point();
        RPCClient rpcclient;
        SortedDictionary<string, string[]> clients;
        List<int> HashRates = new List<int>();

        public MainForm(RPCClient client)
        {
            InitializeComponent();
            rpcclient = client;
            statusBar.Username = "";
            statusBar.Payload = "";
            clients = rpcclient.GetDict();
            defaultPortTextBox.Text = client.DefaultPort;
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
                lock (listBoxClients)
                {
                    int rateSum = 0;
                    int threadSum = 0;
                    int[] arf = { 0, 0, 0 };
                    string[] keys = this.clients.Keys.ToArray();
                    groupClients.SuspendLayout();

                    for (int i = 0; i < keys.Length; i++)
                    {
                        string clientName = keys[i];

                        if (clientName == null)
                            continue;

                        try
                        {
                            ClientInstance item = null;

                            foreach (ClientInstance cntrl in listBoxClients.Controls)
                            {
                                if (cntrl.Name == clientName)
                                {
                                    item = cntrl;
                                    break;
                                }
                            }

                            if (item == null)
                                item = new ClientInstance(clientName, this.clients[keys[i]]);

                            if (listBoxClients.Controls.Contains(item))
                                item.SetAllFields(this.clients[keys[i]]);
                            else
                                this.listBoxClients.Controls.Add(item, 0, clients.Keys.ToList().IndexOf(item.Name));

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
                        catch
                        {
                            continue;
                        }
                    }

                    if (this.clients.Count < listBoxClients.Controls.Count)
                    {
                        ClientInstance client = null;
                        foreach (ClientInstance instance in listBoxClients.Controls)
                        {
                            if (!this.clients.ContainsKey(instance.Name))
                            {
                                client = instance;
                                break;
                            }
                        }

                        if (client != null)
                            listBoxClients.Controls.Remove(client);
                    }

                    if (rateSum > 0)
                        HashRates.Add(rateSum);

                    statusBar.Threads = threadSum.ToString();
                    statusBar.HashRate = GetAverageHashRate().ToString();
                    statusBar.ARF = new string[] { arf[0].ToString(), arf[1].ToString(), arf[2].ToString() };
                    statusBar.ClientName = String.Format("Clients: {0}", this.clients.Count.ToString());
                    groupClients.AutoScrollPosition = scrollPos;
                    groupClients.ResumeLayout();
                }
            }
        }

        private int GetAverageHashRate()
        {
            if (HashRates.Count < 2)
                return HashRates.Sum();

            return HashRates.Sum() / HashRates.Count;
        }

        private void manualIPTextBox_Click(object sender, EventArgs e)
        {
            manualIPTextBox.Clear();
        }

        private void manualIPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter)
            {
                System.Net.IPAddress ip;
                string address = manualIPTextBox.Text;

                if (System.Net.IPAddress.TryParse(address.Split(':')[0].Trim(), out ip))
                {
                    if (!address.Contains(":"))
                        address += ":" + Program.client.DefaultPort;

                    Program.client.ConnectAsTcpClient(address);
                }

                manualIPTextBox.Text = "Enter manual IP address here (127.0.0.1:7111)";
                this.SelectNextControl(manualIPTextBox.Control, false, true, true, true);
            }
            else if (e.KeyChar == (char)System.ConsoleKey.Escape)
            { 
                manualIPTextBox.Text = "Enter manual IP address here (127.0.0.1:7111)";
                this.SelectNextControl(manualIPTextBox.Control, false, true, true, true);
            }
            else if (!"0123456789.:".ToCharArray().Contains(e.KeyChar) ||
                e.KeyChar == (char)System.ConsoleKey.Backspace ||
                e.KeyChar == (char)System.ConsoleKey.LeftArrow ||
                e.KeyChar == (char)System.ConsoleKey.RightArrow)
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void manualIPTextBox_Leave(object sender, EventArgs e)
        {
            manualIPTextBox.Text = "Enter manual IP address here (127.0.0.1:7111)";
        }

        private void groupClients_Scroll(object sender, ScrollEventArgs e)
        {
            scrollPos.Y = e.NewValue;
        }

        private void defaultPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter)
            {
                int temp = -1;

                if (!int.TryParse(defaultPortTextBox.Text, out temp))
                {
                    defaultPortTextBox.Text = Program.client.DefaultPort;
                    e.Handled = false;
                    return;
                }

                Program.client.DefaultPort = defaultPortTextBox.Text;
                this.SelectNextControl(defaultPortTextBox.Control, false, true, true, true);
                Program.client.TimerCallback(null);
            }
            else if (e.KeyChar == (char)System.ConsoleKey.Escape)
            {
                defaultPortTextBox.Text = Program.client.DefaultPort;
                this.SelectNextControl(defaultPortTextBox.Control, false, true, true, true);
            }
            else if (!"0123456789".ToCharArray().Contains(e.KeyChar) ||
                e.KeyChar == (char)System.ConsoleKey.Backspace ||
                e.KeyChar == (char)System.ConsoleKey.LeftArrow ||
                e.KeyChar == (char)System.ConsoleKey.RightArrow)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void defaultPortTextBox_Click(object sender, EventArgs e)
        {
            defaultPortTextBox.Clear();
        }

        private void alwaysOnTop_CheckStateChanged(object sender, EventArgs e)
        {
            MainForm.ActiveForm.TopMost = alwaysOnTop.Checked;
        }

        private void donatePASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Donate().Show(this);
        }
    }
}
