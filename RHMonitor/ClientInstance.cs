using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RHMonitor
{
    public partial class ClientInstance : UserControl
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

        private int[] arf = { 0, 0, 0 };
        private List<int> hashRates = new List<int>();
        private Dictionary<string, string> info = new Dictionary<string, string>();

        public ClientInstance()
        {
            InitializeComponent();
        }

        public ClientInstance(string name, string[] response) : this()
        {
            this.Name = name;
            hashrateLbl.Text = "0 H/s";
            arfLbl.Text = "0 / 0 / 0";
            threadsLbl.Text = "0";
            addressLbl.Text = name;
            SetAllFields(response);

            this.Dock = DockStyle.Top;
        }

        public string Payload
        {
            set
            {
                payloadLbl.Text = value;
            }
        }

        public string Username
        {
            set
            {
                usernameLbl.Text = value;
            }
        }

        public string ClientName
        {
            set
            {
                addressLbl.Text = value;
            }
        }

        public void SetAllFields(string[] response)
        {
            if (response == null)
                return;

            foreach (var line in response)
            {
                string key = line.Split(':')[0].Trim();
                string value = line.Split(':')[1].Trim();
                info[key] = value;
            }

            HashRate = info["speed"];
            ARF = new string[] { info["accepted"], info["rejected"], info["failed"] };
            Threads = info["threads"];
            Username = info["stratum.user"];
            Payload = info["extrapayload"];
        }

        public int GetHashRate()
        {
            return this.GetAverageHashRate();
        }

        public string HashRate
        {
            set
            {
                if (int.Parse(value) == 0)
                    return;

                hashRates.Add(int.Parse(value));
                while (hashRates.Count > 1000)
                    hashRates.RemoveAt(0);

                hashrateLbl.Text = String.Format("{0} H/s", this.GetAverageHashRate());
            }
        }

        public int[] GetARF()
        {
            return arf;
        }

        public string[] ARF
        {
            set
            {
                arf = new int[]{ int.Parse(value[0]), int.Parse(value[1]), int.Parse(value[2])};
                arfLbl.Text = String.Format("{0} / {1} / {2}", arf[0], arf[1], arf[2]);
            }
        }

        public string Threads
        {
            private get
            {
                return threadsLbl.Text;
            }
            set
            {
                threadsLbl.Text = value;
            }
        }

        public int GetThreads()
        {
            return int.Parse(Threads);
        }

        private int GetAverageHashRate()
        {
            if (hashRates.Count < 1)
                return 0;

            return hashRates.Sum() / hashRates.Count;
        }
    }
}
