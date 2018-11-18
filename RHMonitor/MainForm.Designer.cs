namespace RHMonitor
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupClients = new System.Windows.Forms.GroupBox();
            this.listBoxClients = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberOfClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.acceptedBlocks = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.averageHashRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientInstance1 = new RHMonitor.ClientInstance();
            this.groupClients.SuspendLayout();
            this.listBoxClients.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClients
            // 
            this.groupClients.Controls.Add(this.listBoxClients);
            this.groupClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupClients.Location = new System.Drawing.Point(0, 0);
            this.groupClients.MinimumSize = new System.Drawing.Size(0, 266);
            this.groupClients.Name = "groupClients";
            this.groupClients.Size = new System.Drawing.Size(778, 367);
            this.groupClients.TabIndex = 0;
            this.groupClients.TabStop = false;
            this.groupClients.Text = "Clients";
            // 
            // listBoxClients
            // 
            this.listBoxClients.Controls.Add(this.clientInstance1);
            this.listBoxClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClients.Location = new System.Drawing.Point(3, 22);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(772, 342);
            this.listBoxClients.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 25);
            this.toolStripStatusLabel1.Text = "Clients:";
            // 
            // numberOfClients
            // 
            this.numberOfClients.Name = "numberOfClients";
            this.numberOfClients.Size = new System.Drawing.Size(117, 25);
            this.numberOfClients.Spring = true;
            this.numberOfClients.Text = "0";
            this.numberOfClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(78, 25);
            this.toolStripStatusLabel4.Text = "Threads:";
            // 
            // totalThreads
            // 
            this.totalThreads.Name = "totalThreads";
            this.totalThreads.Size = new System.Drawing.Size(117, 25);
            this.totalThreads.Spring = true;
            this.totalThreads.Text = "0";
            this.totalThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 25);
            this.toolStripStatusLabel3.Text = "A/R/F:";
            // 
            // acceptedBlocks
            // 
            this.acceptedBlocks.Name = "acceptedBlocks";
            this.acceptedBlocks.Size = new System.Drawing.Size(117, 25);
            this.acceptedBlocks.Spring = true;
            this.acceptedBlocks.Text = "0 / 0 / 0";
            this.acceptedBlocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 25);
            this.toolStripStatusLabel2.Text = "Hashrate:";
            // 
            // averageHashRate
            // 
            this.averageHashRate.Name = "averageHashRate";
            this.averageHashRate.Size = new System.Drawing.Size(55, 25);
            this.averageHashRate.Text = "0 H/s";
            this.averageHashRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.numberOfClients,
            this.toolStripStatusLabel4,
            this.totalThreads,
            this.toolStripStatusLabel3,
            this.acceptedBlocks,
            this.toolStripStatusLabel2,
            this.averageHashRate,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 30);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.YellowGreen;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // clientInstance1
            // 
            this.clientInstance1.AutoSize = true;
            this.clientInstance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientInstance1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientInstance1.Location = new System.Drawing.Point(3, 3);
            this.clientInstance1.MinimumSize = new System.Drawing.Size(500, 24);
            this.clientInstance1.Name = "clientInstance1";
            this.clientInstance1.Size = new System.Drawing.Size(500, 24);
            this.clientInstance1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 367);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupClients);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 2000);
            this.MinimumSize = new System.Drawing.Size(725, 423);
            this.Name = "MainForm";
            this.Text = "RHMonitor";
            this.groupClients.ResumeLayout(false);
            this.listBoxClients.ResumeLayout(false);
            this.listBoxClients.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClients;
        internal System.Windows.Forms.FlowLayoutPanel listBoxClients;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel numberOfClients;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel totalThreads;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel acceptedBlocks;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel averageHashRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ClientInstance clientInstance1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

