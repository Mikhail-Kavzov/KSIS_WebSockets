
namespace WebSocketUDPServer
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
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TBoxServerAddr = new System.Windows.Forms.TextBox();
            this.TBoxFile = new System.Windows.Forms.TextBox();
            this.UDPLabel = new System.Windows.Forms.Label();
            this.TBoxConInf = new System.Windows.Forms.TextBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.FileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(12, 255);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(461, 69);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Адрес сервера:";
            // 
            // TBoxServerAddr
            // 
            this.TBoxServerAddr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxServerAddr.Enabled = false;
            this.TBoxServerAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxServerAddr.Location = new System.Drawing.Point(479, 282);
            this.TBoxServerAddr.Name = "TBoxServerAddr";
            this.TBoxServerAddr.Size = new System.Drawing.Size(315, 38);
            this.TBoxServerAddr.TabIndex = 9;
            this.TBoxServerAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBoxFile
            // 
            this.TBoxFile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxFile.Enabled = false;
            this.TBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxFile.Location = new System.Drawing.Point(12, 192);
            this.TBoxFile.Name = "TBoxFile";
            this.TBoxFile.Size = new System.Drawing.Size(920, 38);
            this.TBoxFile.TabIndex = 8;
            // 
            // UDPLabel
            // 
            this.UDPLabel.AutoSize = true;
            this.UDPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UDPLabel.Location = new System.Drawing.Point(12, 9);
            this.UDPLabel.Name = "UDPLabel";
            this.UDPLabel.Size = new System.Drawing.Size(826, 69);
            this.UDPLabel.TabIndex = 7;
            this.UDPLabel.Text = "Текущие подключения UDP:";
            // 
            // TBoxConInf
            // 
            this.TBoxConInf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxConInf.Enabled = false;
            this.TBoxConInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxConInf.Location = new System.Drawing.Point(12, 81);
            this.TBoxConInf.Name = "TBoxConInf";
            this.TBoxConInf.Size = new System.Drawing.Size(920, 38);
            this.TBoxConInf.TabIndex = 6;
            this.TBoxConInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLabel.Location = new System.Drawing.Point(0, 122);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(199, 69);
            this.FileLabel.TabIndex = 11;
            this.FileLabel.Text = "Файл:";
            // 
            // WebSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 471);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.TBoxServerAddr);
            this.Controls.Add(this.TBoxFile);
            this.Controls.Add(this.UDPLabel);
            this.Controls.Add(this.TBoxConInf);
            this.Name = "WebSocket";
            this.Text = "UDPServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebSocket_FormClosed);
            this.Load += new System.EventHandler(this.WebSocket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox TBoxServerAddr;
        private System.Windows.Forms.TextBox TBoxFile;
        private System.Windows.Forms.Label UDPLabel;
        private System.Windows.Forms.TextBox TBoxConInf;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Label FileLabel;
    }
}

