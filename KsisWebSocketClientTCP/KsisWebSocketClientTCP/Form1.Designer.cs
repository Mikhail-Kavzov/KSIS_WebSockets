
namespace KsisWebSocketClientTCP
{
    partial class TCPClient
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
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.FolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.TBoxFile = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TBoxAddr = new System.Windows.Forms.TextBox();
            this.TBoxPort = new System.Windows.Forms.TextBox();
            this.LabelAddr = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreateFile.Location = new System.Drawing.Point(131, 286);
            this.BtnCreateFile.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(375, 74);
            this.BtnCreateFile.TabIndex = 0;
            this.BtnCreateFile.Text = "Выбрать папку";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // FolderDlg
            // 
            this.FolderDlg.SelectedPath = "C:\\Users\\User\\Documents";
            // 
            // TBoxFile
            // 
            this.TBoxFile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxFile.Enabled = false;
            this.TBoxFile.Location = new System.Drawing.Point(131, 236);
            this.TBoxFile.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxFile.Name = "TBoxFile";
            this.TBoxFile.Size = new System.Drawing.Size(375, 38);
            this.TBoxFile.TabIndex = 2;
            this.TBoxFile.TextChanged += new System.EventHandler(this.TBoxFile_TextChanged);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Enabled = false;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConnect.Location = new System.Drawing.Point(759, 286);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(471, 74);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Установить соединение";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TBoxAddr
            // 
            this.TBoxAddr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxAddr.Enabled = false;
            this.TBoxAddr.Location = new System.Drawing.Point(759, 145);
            this.TBoxAddr.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxAddr.Name = "TBoxAddr";
            this.TBoxAddr.Size = new System.Drawing.Size(471, 38);
            this.TBoxAddr.TabIndex = 4;
            this.TBoxAddr.Text = "169.254.26.94";
            // 
            // TBoxPort
            // 
            this.TBoxPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxPort.Enabled = false;
            this.TBoxPort.Location = new System.Drawing.Point(759, 236);
            this.TBoxPort.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxPort.Name = "TBoxPort";
            this.TBoxPort.Size = new System.Drawing.Size(471, 38);
            this.TBoxPort.TabIndex = 5;
            this.TBoxPort.Text = "50000";
            // 
            // LabelAddr
            // 
            this.LabelAddr.AutoSize = true;
            this.LabelAddr.Location = new System.Drawing.Point(753, 91);
            this.LabelAddr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelAddr.Name = "LabelAddr";
            this.LabelAddr.Size = new System.Drawing.Size(104, 32);
            this.LabelAddr.TabIndex = 7;
            this.LabelAddr.Text = "Адрес:";
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(753, 189);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(88, 32);
            this.LabelPort.TabIndex = 8;
            this.LabelPort.Text = "Порт:";
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 480);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelAddr);
            this.Controls.Add(this.TBoxPort);
            this.Controls.Add(this.TBoxAddr);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TBoxFile);
            this.Controls.Add(this.BtnCreateFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCPClient_FormClosed);
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.FolderBrowserDialog FolderDlg;
        private System.Windows.Forms.TextBox TBoxFile;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TBoxAddr;
        private System.Windows.Forms.TextBox TBoxPort;
        private System.Windows.Forms.Label LabelAddr;
        private System.Windows.Forms.Label LabelPort;
    }
}

