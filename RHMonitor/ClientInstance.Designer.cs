namespace RHMonitor
{
    partial class ClientInstance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addressLbl = new System.Windows.Forms.Label();
            this.hashrateLbl = new System.Windows.Forms.Label();
            this.arfLbl = new System.Windows.Forms.Label();
            this.threadsLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.payloadLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.32653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.20408F));
            this.tableLayoutPanel1.Controls.Add(this.payloadLbl, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameLbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hashrateLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.arfLbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.threadsLbl, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLbl.Location = new System.Drawing.Point(3, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(128, 24);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Address";
            this.addressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hashrateLbl
            // 
            this.hashrateLbl.AutoSize = true;
            this.hashrateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashrateLbl.Location = new System.Drawing.Point(137, 0);
            this.hashrateLbl.Name = "hashrateLbl";
            this.hashrateLbl.Size = new System.Drawing.Size(86, 24);
            this.hashrateLbl.TabIndex = 1;
            this.hashrateLbl.Text = "Hashrate";
            this.hashrateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // arfLbl
            // 
            this.arfLbl.AutoSize = true;
            this.arfLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arfLbl.Location = new System.Drawing.Point(302, 0);
            this.arfLbl.Name = "arfLbl";
            this.arfLbl.Size = new System.Drawing.Size(104, 24);
            this.arfLbl.TabIndex = 2;
            this.arfLbl.Text = "A / R / F";
            this.arfLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threadsLbl
            // 
            this.threadsLbl.AutoSize = true;
            this.threadsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadsLbl.Location = new System.Drawing.Point(229, 0);
            this.threadsLbl.Name = "threadsLbl";
            this.threadsLbl.Size = new System.Drawing.Size(67, 24);
            this.threadsLbl.TabIndex = 3;
            this.threadsLbl.Text = "Threads";
            this.threadsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLbl.Location = new System.Drawing.Point(412, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(104, 24);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payloadLbl
            // 
            this.payloadLbl.AutoSize = true;
            this.payloadLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payloadLbl.Location = new System.Drawing.Point(522, 0);
            this.payloadLbl.Name = "payloadLbl";
            this.payloadLbl.Size = new System.Drawing.Size(75, 24);
            this.payloadLbl.TabIndex = 5;
            this.payloadLbl.Text = "Payload";
            this.payloadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(600, 24);
            this.Name = "ClientInstance";
            this.Size = new System.Drawing.Size(600, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hashrateLbl;
        private System.Windows.Forms.Label arfLbl;
        private System.Windows.Forms.Label threadsLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label payloadLbl;
        private System.Windows.Forms.Label usernameLbl;
    }
}
