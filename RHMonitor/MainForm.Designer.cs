using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupClients = new System.Windows.Forms.Panel();
            this.listBoxClients = new System.Windows.Forms.TableLayoutPanel();
            this.numberOfClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.acceptedBlocks = new System.Windows.Forms.ToolStripStatusLabel();
            this.averageHashRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientInstance1 = new RHMonitor.ClientInstance();
            this.groupClients.SuspendLayout();
            this.listBoxClients.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClients
            // 
            this.groupClients.AutoScroll = true;
            this.groupClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupClients.Controls.Add(this.listBoxClients);
            this.groupClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupClients.Location = new System.Drawing.Point(0, 0);
            this.groupClients.MinimumSize = new System.Drawing.Size(4, 100);
            this.groupClients.Name = "groupClients";
            this.groupClients.Size = new System.Drawing.Size(660, 200);
            this.groupClients.TabIndex = 0;
            // 
            // listBoxClients
            // 
            this.listBoxClients.AutoSize = true;
            this.listBoxClients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listBoxClients.ColumnCount = 1;
            this.listBoxClients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listBoxClients.Controls.Add(this.clientInstance1, 0, 0);
            this.listBoxClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxClients.Location = new System.Drawing.Point(0, 0);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.RowCount = 1;
            this.listBoxClients.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listBoxClients.Size = new System.Drawing.Size(656, 30);
            this.listBoxClients.TabIndex = 0;
            // 
            // numberOfClients
            // 
            this.numberOfClients.AutoSize = false;
            this.numberOfClients.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.numberOfClients.Margin = new System.Windows.Forms.Padding(8, 2, -4, 2);
            this.numberOfClients.Name = "numberOfClients";
            this.numberOfClients.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.numberOfClients.Size = new System.Drawing.Size(157, 26);
            this.numberOfClients.Spring = true;
            this.numberOfClients.Text = "Clients: 0";
            // 
            // totalThreads
            // 
            this.totalThreads.AutoSize = false;
            this.totalThreads.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.totalThreads.Margin = new System.Windows.Forms.Padding(8, 2, -4, 2);
            this.totalThreads.Name = "totalThreads";
            this.totalThreads.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.totalThreads.Size = new System.Drawing.Size(157, 26);
            this.totalThreads.Spring = true;
            this.totalThreads.Text = "0";
            // 
            // acceptedBlocks
            // 
            this.acceptedBlocks.AutoSize = false;
            this.acceptedBlocks.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.acceptedBlocks.Margin = new System.Windows.Forms.Padding(8, 2, -4, 2);
            this.acceptedBlocks.Name = "acceptedBlocks";
            this.acceptedBlocks.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.acceptedBlocks.Size = new System.Drawing.Size(157, 26);
            this.acceptedBlocks.Spring = true;
            this.acceptedBlocks.Text = "0 / 0 / 0";
            // 
            // averageHashRate
            // 
            this.averageHashRate.AutoSize = false;
            this.averageHashRate.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.averageHashRate.Margin = new System.Windows.Forms.Padding(8, 2, -4, 2);
            this.averageHashRate.Name = "averageHashRate";
            this.averageHashRate.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.averageHashRate.Size = new System.Drawing.Size(157, 26);
            this.averageHashRate.Spring = true;
            this.averageHashRate.Text = "0 H/s";
            this.averageHashRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfClients,
            this.averageHashRate,
            this.totalThreads,
            this.acceptedBlocks});
            this.statusStrip1.Location = new System.Drawing.Point(0, 226);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(660, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 200);
            this.textBox1.MaxLength = 150;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter manual IP address here";
            this.textBox1.WordWrap = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // clientInstance1
            // 
            this.clientInstance1.AutoSize = true;
            this.clientInstance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientInstance1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientInstance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInstance1.Location = new System.Drawing.Point(3, 3);
            this.clientInstance1.MinimumSize = new System.Drawing.Size(500, 24);
            this.clientInstance1.Name = "clientInstance1";
            this.clientInstance1.Size = new System.Drawing.Size(650, 24);
            this.clientInstance1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(660, 256);
            this.Controls.Add(this.groupClients);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 2000);
            this.MinimumSize = new System.Drawing.Size(682, 212);
            this.Name = "MainForm";
            this.Text = "RHMonitor by MasterOfNone  Donate@ 282527-57";
            this.TopMost = true;
            this.groupClients.ResumeLayout(false);
            this.groupClients.PerformLayout();
            this.listBoxClients.ResumeLayout(false);
            this.listBoxClients.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel groupClients;
        internal System.Windows.Forms.TableLayoutPanel listBoxClients;
        private System.Windows.Forms.ToolStripStatusLabel numberOfClients;
        private System.Windows.Forms.ToolStripStatusLabel totalThreads;
        private System.Windows.Forms.ToolStripStatusLabel acceptedBlocks;
        private System.Windows.Forms.ToolStripStatusLabel averageHashRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ClientInstance clientInstance1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

