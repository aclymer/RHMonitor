using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHMonitor
{
    public partial class ClientInstance : UserControl
    {
        private List<int> hashRates = new List<int>();

        public ClientInstance()
        {
            InitializeComponent();
        }

        public ClientInstance(string name, int rate)
        {
            InitializeComponent();
            this.Name = name;
            clientName.Text = name;
            HashRate = rate;
            accepted.Text = "0";
        }

        public string ClientName
        {
            set
            {
                clientName.Text = value;
            }
        }

        public int HashRate
        {
            set
            {
                hashRates.Add(value);
                while (hashRates.Count > 100)
                    hashRates.RemoveAt(0);

                hashRate.Text = GetAverageHashRate();
            }
        }

        private string GetAverageHashRate()
        {
            return String.Format("{0} H/s", hashRates.Sum() / hashRates.Count);
        }
    }
}
