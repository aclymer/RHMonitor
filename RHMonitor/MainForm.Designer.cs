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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.donatePASCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultPortTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.deaultPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualIPTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.clientInstance1 = new RHMonitor.ClientInstance();
            this.statusBar = new RHMonitor.ClientInstance();
            this.groupClients.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClients
            // 
            this.groupClients.AutoScroll = true;
            this.groupClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupClients.Controls.Add(this.listBoxClients);
            this.groupClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupClients.Location = new System.Drawing.Point(0, 62);
            this.groupClients.MinimumSize = new System.Drawing.Size(4, 12);
            this.groupClients.Name = "groupClients";
            this.groupClients.Size = new System.Drawing.Size(698, 94);
            this.groupClients.TabIndex = 0;
            this.groupClients.TabStop = true;
            this.groupClients.Scroll += new System.Windows.Forms.ScrollEventHandler(this.groupClients_Scroll);
            // 
            // listBoxClients
            // 
            this.listBoxClients.AutoSize = true;
            this.listBoxClients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listBoxClients.ColumnCount = 1;
            this.listBoxClients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listBoxClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxClients.Location = new System.Drawing.Point(0, 0);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.RowCount = 1;
            this.listBoxClients.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listBoxClients.Size = new System.Drawing.Size(694, 0);
            this.listBoxClients.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.defaultPortTextBox,
            this.deaultPortToolStripMenuItem,
            this.manualIPTextBox});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(698, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTop,
            this.donatePASCToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.CheckOnClick = true;
            this.alwaysOnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.alwaysOnTop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alwaysOnTop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.alwaysOnTop.Size = new System.Drawing.Size(271, 30);
            this.alwaysOnTop.Text = "Always on &Top";
            this.alwaysOnTop.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alwaysOnTop.CheckStateChanged += new System.EventHandler(this.alwaysOnTop_CheckStateChanged);
            // 
            // donatePASCToolStripMenuItem
            // 
            this.donatePASCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donatePASCToolStripMenuItem.Image")));
            this.donatePASCToolStripMenuItem.Name = "donatePASCToolStripMenuItem";
            this.donatePASCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.donatePASCToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.donatePASCToolStripMenuItem.Text = "&Donate PASC";
            this.donatePASCToolStripMenuItem.Click += new System.EventHandler(this.donatePASCToolStripMenuItem_Click);
            // 
            // defaultPortTextBox
            // 
            this.defaultPortTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.defaultPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultPortTextBox.Margin = new System.Windows.Forms.Padding(1, 0, 3, 1);
            this.defaultPortTextBox.MaxLength = 5;
            this.defaultPortTextBox.Name = "defaultPortTextBox";
            this.defaultPortTextBox.Size = new System.Drawing.Size(65, 31);
            this.defaultPortTextBox.Text = "7111";
            this.defaultPortTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.defaultPortTextBox.ToolTipText = "Enter a new default port here";
            this.defaultPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defaultPortTextBox_KeyPress);
            this.defaultPortTextBox.Click += new System.EventHandler(this.defaultPortTextBox_Click);
            // 
            // deaultPortToolStripMenuItem
            // 
            this.deaultPortToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deaultPortToolStripMenuItem.Enabled = false;
            this.deaultPortToolStripMenuItem.Name = "deaultPortToolStripMenuItem";
            this.deaultPortToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.deaultPortToolStripMenuItem.Text = "Default Port:";
            // 
            // manualIPTextBox
            // 
            this.manualIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manualIPTextBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.manualIPTextBox.MaxLength = 150;
            this.manualIPTextBox.Name = "manualIPTextBox";
            this.manualIPTextBox.Size = new System.Drawing.Size(370, 31);
            this.manualIPTextBox.Text = "Enter manual IP address here (127.0.0.1:7111)";
            this.manualIPTextBox.WordWrap = false;
            this.manualIPTextBox.Leave += new System.EventHandler(this.manualIPTextBox_Leave);
            this.manualIPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.manualIPTextBox_KeyPress);
            this.manualIPTextBox.Click += new System.EventHandler(this.manualIPTextBox_Click);
            // 
            // clientInstance1
            // 
            this.clientInstance1.AutoSize = true;
            this.clientInstance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientInstance1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientInstance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInstance1.Location = new System.Drawing.Point(0, 36);
            this.clientInstance1.MinimumSize = new System.Drawing.Size(500, 24);
            this.clientInstance1.Name = "clientInstance1";
            this.clientInstance1.Padding = new System.Windows.Forms.Padding(3);
            this.clientInstance1.Size = new System.Drawing.Size(698, 26);
            this.clientInstance1.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Location = new System.Drawing.Point(0, 156);
            this.statusBar.MinimumSize = new System.Drawing.Size(500, 24);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(3);
            this.statusBar.Size = new System.Drawing.Size(698, 26);
            this.statusBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 182);
            this.Controls.Add(this.groupClients);
            this.Controls.Add(this.clientInstance1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 238);
            this.Name = "MainForm";
            this.Text = "RHMonitor by MasterOfNone  Donate@ 282527-57";
            this.groupClients.ResumeLayout(false);
            this.groupClients.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel groupClients;
        internal System.Windows.Forms.TableLayoutPanel listBoxClients;
        private ClientInstance clientInstance1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deaultPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox defaultPortTextBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTop;
        private ClientInstance statusBar;
        private System.Windows.Forms.ToolStripTextBox manualIPTextBox;
        private System.Windows.Forms.ToolStripMenuItem donatePASCToolStripMenuItem;
    }
}

