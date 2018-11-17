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
            this.hashRate = new System.Windows.Forms.Label();
            this.accepted = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientName.Location = new System.Drawing.Point(3, 0);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(160, 24);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Client Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.clientName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hashRate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.accepted, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hashRate
            // 
            this.hashRate.AutoSize = true;
            this.hashRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashRate.Location = new System.Drawing.Point(169, 0);
            this.hashRate.Name = "hashRate";
            this.hashRate.Size = new System.Drawing.Size(160, 24);
            this.hashRate.TabIndex = 1;
            this.hashRate.Text = "HashRate (H/s)";
            // 
            // accepted
            // 
            this.accepted.AutoSize = true;
            this.accepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accepted.Location = new System.Drawing.Point(335, 0);
            this.accepted.Name = "accepted";
            this.accepted.Size = new System.Drawing.Size(160, 24);
            this.accepted.TabIndex = 2;
            this.accepted.Text = "Accepted";
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
        private System.Windows.Forms.Label hashRate;
        private System.Windows.Forms.Label accepted;
    }
}
