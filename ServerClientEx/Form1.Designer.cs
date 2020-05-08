namespace ServerClientEx
{
    partial class ServerForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblSystemMessages = new System.Windows.Forms.Label();
            this.txtboxSend = new System.Windows.Forms.TextBox();
            this.txtboxSysMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtboxReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Server";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 54);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(102, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Enter your text here:";
            // 
            // lblSystemMessages
            // 
            this.lblSystemMessages.AutoSize = true;
            this.lblSystemMessages.Location = new System.Drawing.Point(12, 216);
            this.lblSystemMessages.Name = "lblSystemMessages";
            this.lblSystemMessages.Size = new System.Drawing.Size(95, 13);
            this.lblSystemMessages.TabIndex = 2;
            this.lblSystemMessages.Text = "System Messages:";
            // 
            // txtboxSend
            // 
            this.txtboxSend.Location = new System.Drawing.Point(15, 79);
            this.txtboxSend.Multiline = true;
            this.txtboxSend.Name = "txtboxSend";
            this.txtboxSend.Size = new System.Drawing.Size(262, 111);
            this.txtboxSend.TabIndex = 3;
            // 
            // txtboxSysMsg
            // 
            this.txtboxSysMsg.Location = new System.Drawing.Point(15, 241);
            this.txtboxSysMsg.Multiline = true;
            this.txtboxSysMsg.Name = "txtboxSysMsg";
            this.txtboxSysMsg.Size = new System.Drawing.Size(262, 85);
            this.txtboxSysMsg.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(202, 196);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtboxReceive
            // 
            this.txtboxReceive.Location = new System.Drawing.Point(335, 64);
            this.txtboxReceive.Multiline = true;
            this.txtboxReceive.Name = "txtboxReceive";
            this.txtboxReceive.Size = new System.Drawing.Size(224, 262);
            this.txtboxReceive.TabIndex = 6;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtboxReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtboxSysMsg);
            this.Controls.Add(this.txtboxSend);
            this.Controls.Add(this.lblSystemMessages);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblSystemMessages;
        private System.Windows.Forms.TextBox txtboxSend;
        private System.Windows.Forms.TextBox txtboxSysMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtboxReceive;
    }
}

