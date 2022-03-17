
namespace WebSocketUDPClient
{
    partial class UDPClient
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
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelAddr = new System.Windows.Forms.Label();
            this.TBoxPort = new System.Windows.Forms.TextBox();
            this.TBoxAddr = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TBoxFile = new System.Windows.Forms.TextBox();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.FolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPort.Location = new System.Drawing.Point(740, 192);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(88, 32);
            this.LabelPort.TabIndex = 16;
            this.LabelPort.Text = "Порт:";
            // 
            // LabelAddr
            // 
            this.LabelAddr.AutoSize = true;
            this.LabelAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddr.Location = new System.Drawing.Point(740, 94);
            this.LabelAddr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelAddr.Name = "LabelAddr";
            this.LabelAddr.Size = new System.Drawing.Size(104, 32);
            this.LabelAddr.TabIndex = 15;
            this.LabelAddr.Text = "Адрес:";
            // 
            // TBoxPort
            // 
            this.TBoxPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxPort.Enabled = false;
            this.TBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxPort.Location = new System.Drawing.Point(746, 239);
            this.TBoxPort.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxPort.Name = "TBoxPort";
            this.TBoxPort.Size = new System.Drawing.Size(471, 38);
            this.TBoxPort.TabIndex = 13;
            this.TBoxPort.Text = "50000";
            // 
            // TBoxAddr
            // 
            this.TBoxAddr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxAddr.Enabled = false;
            this.TBoxAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxAddr.Location = new System.Drawing.Point(746, 148);
            this.TBoxAddr.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxAddr.Name = "TBoxAddr";
            this.TBoxAddr.Size = new System.Drawing.Size(471, 38);
            this.TBoxAddr.TabIndex = 12;
            this.TBoxAddr.Text = "169.254.26.94";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Enabled = false;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConnect.Location = new System.Drawing.Point(746, 289);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(471, 74);
            this.BtnConnect.TabIndex = 11;
            this.BtnConnect.Text = "Установить соединение";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TBoxFile
            // 
            this.TBoxFile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxFile.Enabled = false;
            this.TBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxFile.Location = new System.Drawing.Point(118, 239);
            this.TBoxFile.Margin = new System.Windows.Forms.Padding(6);
            this.TBoxFile.Name = "TBoxFile";
            this.TBoxFile.Size = new System.Drawing.Size(375, 38);
            this.TBoxFile.TabIndex = 10;
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreateFile.Location = new System.Drawing.Point(118, 289);
            this.BtnCreateFile.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(375, 74);
            this.BtnCreateFile.TabIndex = 9;
            this.BtnCreateFile.Text = "Выбрать папку";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // FolderDlg
            // 
            this.FolderDlg.SelectedPath = "C:\\Users\\User\\Documents";
            // 
            // timerReceive
            // 
            this.timerReceive.Enabled = true;
            this.timerReceive.Interval = 5000;
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 457);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelAddr);
            this.Controls.Add(this.TBoxPort);
            this.Controls.Add(this.TBoxAddr);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TBoxFile);
            this.Controls.Add(this.BtnCreateFile);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.Load += new System.EventHandler(this.UDPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelAddr;
        private System.Windows.Forms.TextBox TBoxPort;
        private System.Windows.Forms.TextBox TBoxAddr;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TBoxFile;
        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.FolderBrowserDialog FolderDlg;
        private System.Windows.Forms.Timer timerReceive;
    }
}

