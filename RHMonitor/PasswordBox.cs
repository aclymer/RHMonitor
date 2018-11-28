using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHMonitor
{
    public partial class PasswordBox : Form
    {
        private string pw = "";

        public PasswordBox()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter)
            {
                pw = textBox1.Text;
                textBox1.Clear();
                this.Close();
            }
        }

        public new string Show()
        {
            base.Show();
            return pw;
        }
    }
}
