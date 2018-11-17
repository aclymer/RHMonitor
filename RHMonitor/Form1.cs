using System;
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
    public partial class Form1 : Form
    {
        delegate void DictArgReturningVoidDelegate(Dictionary<string, string> text);

        RPCClient rpcclient;
        Dictionary<string, string> clients;
        List<int> HashRates = new List<int>();

        public Form1(RPCClient client)
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

        private void SetText(Dictionary<string, string> clients)
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

                for (int i = 0; i < this.clients.Count; i++)
                {
                    int clientRate = int.Parse(this.clients[this.clients.Keys.ElementAt(i)].Split(' ')[0]);
                    rateSum += clientRate;

                    Control item = new ClientInstance(this.clients.Keys.ElementAt(i), clientRate);

                    foreach (Control cntrl in listBoxClients.Controls)
                    {
                        if (cntrl.Name == item.Name)
                        {
                            item = cntrl;
                            break;
                        }
                    }

                    if (listBoxClients.Controls.Contains(item))
                    {
                        ((ClientInstance)listBoxClients.Controls[listBoxClients.Controls.GetChildIndex(item)]).ClientName = item.Name;
                        ((ClientInstance)listBoxClients.Controls[listBoxClients.Controls.GetChildIndex(item)]).HashRate = int.Parse(this.clients[this.clients.Keys.ElementAt(i)].Split(' ')[0]);
                    }
                    else
                        this.listBoxClients.Controls.Add(item);

                    listBoxClients.Update();
                }

                HashRates.Add(rateSum);
                while (HashRates.Count > 100)
                    HashRates.RemoveAt(0);

                averageHashRate.Text = String.Format("{0} H/s", HashRates.Sum() / HashRates.Count);
                numberOfClients.Text = this.clients.Count.ToString();
            }
        }
    }
}
