using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WebSocketUDPServer
{
    public partial class WebSocket : Form
    {
        public WebSocket()
        {
            InitializeComponent();
        }
        private Socket socket;
        private const int PORT_SERVER = 50000;

        private const int BUFFER_LEN = 256;
        private const int backlog = 10;
        private IPAddress ip;
        private IPEndPoint IPEPoint;
        
        //  private string host;
        byte[] buf;
        byte[] connectbuf;
        Thread thr;

        private void WebSocket_Load(object sender, EventArgs e)
        {
            try
            {   
                buf = new byte[BUFFER_LEN];
                connectbuf = new byte[1];
                string host = Dns.GetHostName();
                ip = Dns.GetHostByName(host).AddressList[1];
                TBoxServerAddr.Text = ip.ToString();
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEPoint = new IPEndPoint(ip, PORT_SERVER);
                socket.Bind(IPEPoint);
               
                thr = new Thread(SendData);
                thr.IsBackground = true;
                thr.Start();

            }
            catch (SocketException ex)
            {

                MessageBox.Show("Cannot create a socket \nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("IP Address is not valid\nSource:" + ex.Source +
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
        private delegate void MyDelegate( EndPoint senderRemote);
        private void MSent( EndPoint senderRemote)
        {
            try {

                
                string IpAddr = ((IPEndPoint)senderRemote).Address.ToString();
                string PortAddr = ((IPEndPoint)senderRemote).Port.ToString();
                var result = MessageBox.Show("New connection from " + IpAddr +
                   ":" + PortAddr,
                   "New Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result != DialogResult.OK)
                {
                    buf[0] = 12;
                    socket.SendTo(buf, senderRemote);
                    throw new Exception("Подключение прервано");
                }
                TBoxConInf.Text =IpAddr + ":" + PortAddr;
                if (openFileDlg.ShowDialog() != DialogResult.OK)
                {
                    buf[0] = 12;
                    socket.SendTo(buf, senderRemote);
                    throw new Exception("Подключение прервано");
                }
                        string fname = openFileDlg.FileName;
                        TBoxFile.Text = fname;

                        int i = fname.Length - 1;
                        while (fname[i] != '\\')
                        { --i; }
                        string shortname = fname.Substring(i + 1);
                        buf[0] = (byte)shortname.Length;
                        for (int j = 0; j < buf[0]; j++)
                         buf[j + 1] = (byte)shortname[j];
                        socket.SendTo(buf,senderRemote);

                        FileStream rdFile = new FileStream(fname, FileMode.Open, FileAccess.Read);
                        byte count = 0;
                        while ((count = (byte)rdFile.Read(buf, 1, BUFFER_LEN - 1)) != 0)
                        {
                            buf[0] = count;
                            socket.SendTo(buf,senderRemote);
                        }
                        rdFile.Close();
                MessageBox.Show("Передача завершена", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error Client Socket \nSource:" + ex.Source +
                  "\nMessage" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("IP Address is not valid\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unknown Error\nSource:" + ex.Source +
                    "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
               
            }
           
        }
        [STAThread]
        private void SendData()
        {

            while (true)
            {
                try
                {

                    EndPoint senderRemote = (EndPoint)IPEPoint;
                    socket.ReceiveFrom(connectbuf, ref senderRemote);

                    EndInvoke(BeginInvoke(new MyDelegate(MSent), senderRemote));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown Error\nSource:" + ex.Source +
                       "\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void WebSocket_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (socket != null)
            {
                // socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }


       
    }
}
