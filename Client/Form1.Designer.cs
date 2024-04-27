namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPort = new TextBox();
            label2 = new Label();
            txtHost = new TextBox();
            label1 = new Label();
            btnConnect = new Button();
            txtMessage = new TextBox();
            btnSend = new Button();
            txtStatus = new TextBox();
            SuspendLayout();
            // 
            // txtPort
            // 
            txtPort.Location = new Point(402, 61);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(70, 31);
            txtPort.TabIndex = 11;
            txtPort.Text = "8910";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 10;
            label2.Text = "Port:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(152, 61);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(180, 31);
            txtHost.TabIndex = 9;
            txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 8;
            label1.Text = "Host:";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(488, 59);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(177, 34);
            btnConnect.TabIndex = 12;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(152, 98);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(712, 83);
            txtMessage.TabIndex = 13;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(687, 187);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(177, 47);
            btnSend.TabIndex = 14;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(152, 240);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(712, 322);
            txtStatus.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 592);
            Controls.Add(txtStatus);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(btnConnect);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPort;
        private Label label2;
        private TextBox txtHost;
        private Label label1;
        private Button btnConnect;
        private TextBox txtMessage;
        private Button btnSend;
        private TextBox txtStatus;
    }
}
