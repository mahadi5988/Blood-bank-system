
namespace BloodBank_Video
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestForBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkRequestStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAvailableBloodStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.requestForBloodToolStripMenuItem,
            this.checkRequestStatusToolStripMenuItem,
            this.ViewAvailableBloodStockToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 68);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorToolStripMenuItem.Image")));
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(160, 64);
            this.donorToolStripMenuItem.Text = "Profile Detail";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // requestForBloodToolStripMenuItem
            // 
            this.requestForBloodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("requestForBloodToolStripMenuItem.Image")));
            this.requestForBloodToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.requestForBloodToolStripMenuItem.Name = "requestForBloodToolStripMenuItem";
            this.requestForBloodToolStripMenuItem.Size = new System.Drawing.Size(193, 64);
            this.requestForBloodToolStripMenuItem.Text = "Request for Blood";
            this.requestForBloodToolStripMenuItem.Click += new System.EventHandler(this.requestForBloodToolStripMenuItem_Click);
            // 
            // checkRequestStatusToolStripMenuItem
            // 
            this.checkRequestStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkRequestStatusToolStripMenuItem.Image")));
            this.checkRequestStatusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.checkRequestStatusToolStripMenuItem.Name = "checkRequestStatusToolStripMenuItem";
            this.checkRequestStatusToolStripMenuItem.Size = new System.Drawing.Size(213, 64);
            this.checkRequestStatusToolStripMenuItem.Text = "Check Request Status";
            this.checkRequestStatusToolStripMenuItem.Click += new System.EventHandler(this.checkRequestStatusToolStripMenuItem_Click);
            // 
            // ViewAvailableBloodStockToolStripMenuItem
            // 
            this.ViewAvailableBloodStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ViewAvailableBloodStockToolStripMenuItem.Image")));
            this.ViewAvailableBloodStockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewAvailableBloodStockToolStripMenuItem.Name = "ViewAvailableBloodStockToolStripMenuItem";
            this.ViewAvailableBloodStockToolStripMenuItem.Size = new System.Drawing.Size(255, 64);
            this.ViewAvailableBloodStockToolStripMenuItem.Text = "View Available Blood Stock";
            this.ViewAvailableBloodStockToolStripMenuItem.Click += new System.EventHandler(this.ViewAvailableBloodStockToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(136, 64);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestForBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkRequestStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewAvailableBloodStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}