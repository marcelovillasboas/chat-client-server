namespace ClientForm
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.txtMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxSend = new System.Windows.Forms.TextBox();
            this.txtBoxSysMsg = new System.Windows.Forms.TextBox();
            this.lblSysMsg = new System.Windows.Forms.Label();
            this.txtboxReceive = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(12, 54);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(105, 13);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "Enter your text here: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Client";
            // 
            // txtboxSend
            // 
            this.txtboxSend.Location = new System.Drawing.Point(15, 80);
            this.txtboxSend.Multiline = true;
            this.txtboxSend.Name = "txtboxSend";
            this.txtboxSend.Size = new System.Drawing.Size(282, 97);
            this.txtboxSend.TabIndex = 2;
            // 
            // txtBoxSysMsg
            // 
            this.txtBoxSysMsg.Location = new System.Drawing.Point(15, 239);
            this.txtBoxSysMsg.Multiline = true;
            this.txtBoxSysMsg.Name = "txtBoxSysMsg";
            this.txtBoxSysMsg.Size = new System.Drawing.Size(282, 92);
            this.txtBoxSysMsg.TabIndex = 3;
            // 
            // lblSysMsg
            // 
            this.lblSysMsg.AutoSize = true;
            this.lblSysMsg.Location = new System.Drawing.Point(12, 214);
            this.lblSysMsg.Name = "lblSysMsg";
            this.lblSysMsg.Size = new System.Drawing.Size(90, 13);
            this.lblSysMsg.TabIndex = 4;
            this.lblSysMsg.Text = "System Message:";
            // 
            // txtboxReceive
            // 
            this.txtboxReceive.Location = new System.Drawing.Point(350, 54);
            this.txtboxReceive.Multiline = true;
            this.txtboxReceive.Name = "txtboxReceive";
            this.txtboxReceive.Size = new System.Drawing.Size(200, 277);
            this.txtboxReceive.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(222, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtboxReceive);
            this.Controls.Add(this.lblSysMsg);
            this.Controls.Add(this.txtBoxSysMsg);
            this.Controls.Add(this.txtboxSend);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMessage);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxSend;
        private System.Windows.Forms.TextBox txtBoxSysMsg;
        private System.Windows.Forms.Label lblSysMsg;
        private System.Windows.Forms.TextBox txtboxReceive;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSend;
    }
}

