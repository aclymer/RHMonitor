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
            this.clientName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hashRateLbl = new System.Windows.Forms.Label();
            this.arfLbl = new System.Windows.Forms.Label();
            this.threadsLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientName.Location = new System.Drawing.Point(3, 0);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(144, 24);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Address";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.25F));
            this.tableLayoutPanel1.Controls.Add(this.clientName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hashRateLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.arfLbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.threadsLbl, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hashRateLbl
            // 
            this.hashRateLbl.AutoSize = true;
            this.hashRateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashRateLbl.Location = new System.Drawing.Point(153, 0);
            this.hashRateLbl.Name = "hashRateLbl";
            this.hashRateLbl.Size = new System.Drawing.Size(144, 24);
            this.hashRateLbl.TabIndex = 1;
            this.hashRateLbl.Text = "HashRate";
            // 
            // arfLbl
            // 
            this.arfLbl.AutoSize = true;
            this.arfLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arfLbl.Location = new System.Drawing.Point(378, 0);
            this.arfLbl.Name = "arfLbl";
            this.arfLbl.Size = new System.Drawing.Size(94, 24);
            this.arfLbl.TabIndex = 2;
            this.arfLbl.Text = "A / R / F";
            // 
            // threadsLbl
            // 
            this.threadsLbl.AutoSize = true;
            this.threadsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadsLbl.Location = new System.Drawing.Point(303, 0);
            this.threadsLbl.Name = "threadsLbl";
            this.threadsLbl.Size = new System.Drawing.Size(69, 24);
            this.threadsLbl.TabIndex = 3;
            this.threadsLbl.Text = "Threads";
            // 
            // ClientInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(500, 24);
            this.Name = "ClientInstance";
            this.Size = new System.Drawing.Size(500, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hashRateLbl;
        private System.Windows.Forms.Label arfLbl;
        private System.Windows.Forms.Label threadsLbl;
    }
}
