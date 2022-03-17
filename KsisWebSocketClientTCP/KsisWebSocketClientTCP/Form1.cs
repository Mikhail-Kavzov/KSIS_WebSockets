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
using System.Net;
using System.Net.Sockets;

namespace KsisWebSocketClientTCP
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }
        private string fname;
        private const int BUF_SIZE = 256;
        private byte[] buf;
        Socket socket;
        string fullpath;

        private void TCPClient_Load(object sender, EventArgs e)
        {
            try
            {
                buf = new byte[BUF_SIZE];
               
               // socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);

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
        

        private void TBoxFile_TextChanged(object sender, EventArgs e)
        {
            if (TBoxFile.Text.Length==0)
            {
                BtnCreateFile.Enabled = false;
            }
            else
            {
                BtnCreateFile.Enabled = true;
            }
        }

        private void BtnCreateFile_Click(object sender, EventArgs e)
        {   
            if (FolderDlg.ShowDialog()==DialogResult.OK)
            {
                fname = FolderDlg.SelectedPath + "\\";
                TBoxFile.Text = fname;
                fullpath = fname;
                BtnConnect.Enabled = true;
                TBoxAddr.Enabled = true;
                TBoxPort.Enabled = true;
            }

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            BtnCreateFile.Enabled = false;
            IPAddress ipAddress;
            int Port;

            FileStream wrFile=null;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ipAddress = IPAddress.Parse(TBoxAddr.Text);
                Port = int.Parse(TBoxPort.Text);
                socket.Connect(ipAddress, Port);
                fname = fullpath;
                if (socket.Receive(buf) > 0)
                {
                    for (int i = 1; i <= buf[0]; i++)
                    {

                        fname += (char)buf[i];
                    }
                }
                if(fname.Equals(fullpath))
                    throw new Exception("Файл недоступен");
                wrFile = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
                    int counter = 0;
                    while (socket.Receive(buf)>0) // вернет число байт считанных 0 - чтение закончилось
                { 
                    wrFile.Write(buf, 1, buf[0]);
                    ++counter;
                }
                if (counter == 0)
                    throw new Exception("Файл недоступен");
                MessageBox.Show("Передача завершена", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                socket.Shutdown(SocketShutdown.Both);
                socket.Disconnect(true);
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
            {   if (wrFile!=null)
                wrFile.Close();
            }
            BtnCreateFile.Enabled = true;
        }

        private void TCPClient_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (socket != null)
            {
                //socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
    
}
