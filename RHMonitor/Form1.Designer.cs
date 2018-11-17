namespace RHMonitor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfClients = new System.Windows.Forms.Label();
            this.averageHashRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientInstance1 = new RHMonitor.ClientInstance();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acceptedBlocks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupClients.SuspendLayout();
            this.listBoxClients.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClients
            // 
            this.groupClients.Controls.Add(this.listBoxClients);
            this.groupClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupClients.Location = new System.Drawing.Point(0, 0);
            this.groupClients.MinimumSize = new System.Drawing.Size(0, 266);
            this.groupClients.Name = "groupClients";
            this.groupClients.Size = new System.Drawing.Size(800, 267);
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
            this.listBoxClients.Size = new System.Drawing.Size(794, 242);
            this.listBoxClients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients:";
            // 
            // numberOfClients
            // 
            this.numberOfClients.AutoSize = true;
            this.numberOfClients.Location = new System.Drawing.Point(140, 26);
            this.numberOfClients.Name = "numberOfClients";
            this.numberOfClients.Size = new System.Drawing.Size(18, 20);
            this.numberOfClients.TabIndex = 2;
            this.numberOfClients.Text = "0";
            // 
            // averageHashRate
            // 
            this.averageHashRate.AutoSize = true;
            this.averageHashRate.Location = new System.Drawing.Point(140, 56);
            this.averageHashRate.Name = "averageHashRate";
            this.averageHashRate.Size = new System.Drawing.Size(18, 20);
            this.averageHashRate.TabIndex = 4;
            this.averageHashRate.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hashrate:";
            // 
            // clientInstance1
            // 
            this.clientInstance1.AutoSize = true;
            this.clientInstance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientInstance1.Location = new System.Drawing.Point(3, 3);
            this.clientInstance1.MinimumSize = new System.Drawing.Size(500, 24);
            this.clientInstance1.Name = "clientInstance1";
            this.clientInstance1.Size = new System.Drawing.Size(500, 24);
            this.clientInstance1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.acceptedBlocks);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.averageHashRate);
            this.panel1.Controls.Add(this.numberOfClients);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // acceptedBlocks
            // 
            this.acceptedBlocks.AutoSize = true;
            this.acceptedBlocks.Location = new System.Drawing.Point(451, 40);
            this.acceptedBlocks.Name = "acceptedBlocks";
            this.acceptedBlocks.Size = new System.Drawing.Size(18, 20);
            this.acceptedBlocks.TabIndex = 6;
            this.acceptedBlocks.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accepted:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.groupClients);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(0, 423);
            this.Name = "Form1";
            this.Text = "RHMonitor";
            this.groupClients.ResumeLayout(false);
            this.listBoxClients.ResumeLayout(false);
            this.listBoxClients.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClients;
        internal System.Windows.Forms.FlowLayoutPanel listBoxClients;
        private ClientInstance clientInstance1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfClients;
        private System.Windows.Forms.Label averageHashRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acceptedBlocks;
        private System.Windows.Forms.Label label4;
    }
}

