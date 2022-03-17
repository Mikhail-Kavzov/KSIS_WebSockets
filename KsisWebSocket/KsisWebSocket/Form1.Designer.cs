
namespace KsisWebSocket
{
    partial class WebSocket
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
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.TBoxFile = new System.Windows.Forms.TextBox();
            this.TBoxServerAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.TCPLabel = new System.Windows.Forms.Label();
            this.TBoxConnect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBoxFile
            // 
            this.TBoxFile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxFile.Enabled = false;
            this.TBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxFile.Location = new System.Drawing.Point(24, 189);
            this.TBoxFile.Name = "TBoxFile";
            this.TBoxFile.Size = new System.Drawing.Size(920, 38);
            this.TBoxFile.TabIndex = 2;
            // 
            // TBoxServerAddr
            // 
            this.TBoxServerAddr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxServerAddr.Enabled = false;
            this.TBoxServerAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxServerAddr.Location = new System.Drawing.Point(496, 270);
            this.TBoxServerAddr.Name = "TBoxServerAddr";
            this.TBoxServerAddr.Size = new System.Drawing.Size(315, 38);
            this.TBoxServerAddr.TabIndex = 3;
            this.TBoxServerAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес сервера:";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLabel.Location = new System.Drawing.Point(12, 117);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(199, 69);
            this.FileLabel.TabIndex = 5;
            this.FileLabel.Text = "Файл:";
            // 
            // TCPLabel
            // 
            this.TCPLabel.AutoSize = true;
            this.TCPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCPLabel.Location = new System.Drawing.Point(12, 9);
            this.TCPLabel.Name = "TCPLabel";
            this.TCPLabel.Size = new System.Drawing.Size(820, 69);
            this.TCPLabel.TabIndex = 6;
            this.TCPLabel.Text = "Текущие подключения TCP:";
            // 
            // TBoxConnect
            // 
            this.TBoxConnect.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxConnect.Enabled = false;
            this.TBoxConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxConnect.Location = new System.Drawing.Point(24, 81);
            this.TBoxConnect.Name = "TBoxConnect";
            this.TBoxConnect.Size = new System.Drawing.Size(920, 38);
            this.TBoxConnect.TabIndex = 7;
            // 
            // WebSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 455);
            this.Controls.Add(this.TBoxConnect);
            this.Controls.Add(this.TCPLabel);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxServerAddr);
            this.Controls.Add(this.TBoxFile);
            this.Name = "WebSocket";
            this.Text = "WebSocket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebSocket_FormClosed);
            this.Load += new System.EventHandler(this.WebSocket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.TextBox TBoxFile;
        private System.Windows.Forms.TextBox TBoxServerAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label TCPLabel;
        private System.Windows.Forms.TextBox TBoxConnect;
    }
}

