using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPascalCoin;

namespace RHMonitor
{
    public partial class Donate : Form
    {
        internal NPascalCoin.RPC.PascalCoinClient PascClient;

        public Donate()
        {
            InitializeComponent();
        }

        private void Donate_Shown(object sender, EventArgs e)
        {
            PascClient = new NPascalCoin.RPC.PascalCoinClient();
            var accounts = PascClient.GetWalletAccounts();

            accounts = accounts.Where(x => { return x.Balance >= 1; }).ToArray<NPascalCoin.DTO.AccountDTO>();

            foreach (var account in accounts)
            {
                var item = new ListViewItem(new[] { account.Account.ToString(), account.Balance.ToString("N4") });
                item.Name = account.Account.ToString();
                senderAccountListView.Items.Add(item);
            }

            senderAccountListView.Columns[0].Width = tableLayoutPanel1.Width / 2 - 10;
            senderAccountListView.Columns[1].Width = tableLayoutPanel1.Width / 2 - 10;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (senderAccountListView.SelectedItems.Count < 1)
                return;

            var item = senderAccountListView.SelectedItems[0];
            var account = uint.Parse(item.Name);
            var amount = numericUpDown1.Value;
            NPascalCoin.DTO.OperationDTO result = null;

            try
            {
                await PascClient.UnlockAsync(new PasswordBox().Show());

                result = PascClient.SendTo(account, 282527, amount, 0.01M, Encoding.ASCII.GetBytes("RHMonitor_Donation"), PayloadEncryptionMethod.None);

                MessageBox.Show(this, "Thank You!", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            catch(NPascalCoin.RPC.PascalCoinRPCException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                return;
            }
        }
    }
}
