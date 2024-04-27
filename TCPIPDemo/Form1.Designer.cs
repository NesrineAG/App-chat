namespace TCPIPDemo
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
            btnStart = new Button();
            label1 = new Label();
            txtHost = new TextBox();
            txtPort = new TextBox();
            label2 = new Label();
            btnStop = new Button();
            txtStatus = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(471, 50);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Host:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(125, 53);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(180, 31);
            txtHost.TabIndex = 2;
            txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(375, 53);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(70, 31);
            txtPort.TabIndex = 4;
            txtPort.Text = "8910";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 58);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(616, 49);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(140, 34);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(125, 90);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(631, 259);
            txtStatus.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 460);
            Controls.Add(txtStatus);
            Controls.Add(btnStop);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private TextBox txtHost;
        private TextBox txtPort;
        private Label label2;
        private Button btnStop;
        private TextBox txtStatus;
    }
}
