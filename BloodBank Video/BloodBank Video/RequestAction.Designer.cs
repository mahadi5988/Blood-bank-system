
namespace BloodBank_Video
{
    partial class RequestAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestAction));
            this.btnExit = new XanderUI.XUIButton();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtRequired = new System.Windows.Forms.TextBox();
            this.txtRequestedDate = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnCheckBloodStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.btnExit.ButtonText = "X";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.CornerRadius = 5;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(672, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 39);
            this.btnExit.TabIndex = 36;
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Requested",
            "Approved",
            "Rejected"});
            this.txtStatus.Location = new System.Drawing.Point(324, 377);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(199, 28);
            this.txtStatus.TabIndex = 48;
            this.txtStatus.SelectedIndexChanged += new System.EventHandler(this.txtStatus_SelectedIndexChanged);
            // 
            // txtRequired
            // 
            this.txtRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequired.Location = new System.Drawing.Point(324, 256);
            this.txtRequired.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequired.Name = "txtRequired";
            this.txtRequired.Size = new System.Drawing.Size(199, 26);
            this.txtRequired.TabIndex = 44;
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestedDate.Location = new System.Drawing.Point(324, 316);
            this.txtRequestedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.Size = new System.Drawing.Size(199, 26);
            this.txtRequestedDate.TabIndex = 45;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGroup.Location = new System.Drawing.Point(324, 195);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(199, 26);
            this.txtBloodGroup.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 381);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Requested Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Required Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Blood Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "Approve / Reject";
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(324, 436);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(199, 26);
            this.txtReason.TabIndex = 50;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.BackColor = System.Drawing.Color.Transparent;
            this.labelReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.Location = new System.Drawing.Point(172, 442);
            this.labelReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(72, 20);
            this.labelReason.TabIndex = 51;
            this.labelReason.Text = "Reason";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStatus.Location = new System.Drawing.Point(173, 503);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(350, 38);
            this.btnUpdateStatus.TabIndex = 52;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnCheckBloodStock
            // 
            this.btnCheckBloodStock.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckBloodStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckBloodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBloodStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBloodStock.Location = new System.Drawing.Point(173, 573);
            this.btnCheckBloodStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBloodStock.Name = "btnCheckBloodStock";
            this.btnCheckBloodStock.Size = new System.Drawing.Size(350, 38);
            this.btnCheckBloodStock.TabIndex = 53;
            this.btnCheckBloodStock.Text = "Check Blood Stock";
            this.btnCheckBloodStock.UseVisualStyleBackColor = false;
            this.btnCheckBloodStock.Click += new System.EventHandler(this.btnCheckBloodStock_Click);
            // 
            // RequestAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(725, 754);
            this.Controls.Add(this.btnCheckBloodStock);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRequired);
            this.Controls.Add(this.txtRequestedDate);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestAction";
            this.Load += new System.EventHandler(this.RequestAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnExit;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.TextBox txtRequired;
        private System.Windows.Forms.TextBox txtRequestedDate;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnCheckBloodStock;
    }
}