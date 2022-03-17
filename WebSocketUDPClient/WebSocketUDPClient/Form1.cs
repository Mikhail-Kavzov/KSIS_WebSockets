using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace WebSocketUDPClient
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }
        private string fname;
        private const int BUF_SIZE = 256;
        private byte[] buf;
        private byte[] connectBuf;
        Socket socket;
        string fullpath;
      

        private void UDPClient_Load(object sender, EventArgs e)
        {
            try
            {
                buf = new byte[BUF_SIZE];
                connectBuf = new byte[1];
                
               


            }
            catch (SocketException ex)
            {

                MessageBox.Show("Cannot create a socket \nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Unknown Error\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

      

        private void BtnCreateFile_Click(object sender, EventArgs e)
        {
            if (FolderDlg.ShowDialog() == DialogResult.OK)
            {
                fname = FolderDlg.SelectedPath + "\\";
                TBoxFile.Text = fname;
                fullpath = fname;
                BtnConnect.Enabled = true;
                TBoxAddr.Enabled = true;
                TBoxPort.Enabled = true;
            }

        }
        private delegate void MDel();
        private void ExchBtn()
        {
            BtnCreateFile.Enabled = true;
            BtnConnect.Enabled = true;
        }
        [STAThread]
        private void ReceiveData()
        {
            IPAddress ipAddress;
            int Port;

            FileStream wrFile = null;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                ipAddress = IPAddress.Parse(TBoxAddr.Text);

                Port = int.Parse(TBoxPort.Text);
                IPEndPoint IPEPoint = new IPEndPoint(ipAddress, Port);
                EndPoint EndP = (EndPoint)IPEPoint;

                socket.SendTo(connectBuf, EndP);

                socket.ReceiveFrom(buf, ref EndP);
                if (buf[0]==12)
                    throw new Exception("Файл недоступен");
                fname = fullpath;
                for (int i = 1; i <= buf[0]; i++)
                {

                    fname += (char)buf[i];
                }
                if (fname.Equals(fullpath))
                    throw new Exception("Файл недоступен");

                buf[0] = BUF_SIZE - 1;
                wrFile = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
                while (buf[0]==BUF_SIZE-1)
                {
                    socket.ReceiveFrom(buf, ref EndP);
                    wrFile.Write(buf, 1, buf[0]);
                }


                MessageBox.Show("Передача завершена", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not Found\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("IP Address is not valid\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Connection is Failed\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unknown Error\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (wrFile != null)
                    wrFile.Close();
                if (socket != null)
                {
                    //socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
               EndInvoke(BeginInvoke(new MDel(ExchBtn)));
            }
          
            
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            BtnCreateFile.Enabled = false;
            BtnConnect.Enabled = false;
            Thread thr = new Thread(ReceiveData);
            thr.IsBackground = true;
            thr.Start();
            
            
            
        }

        private void UDPClient_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (socket != null)
            {
                //socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
