using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;

namespace KsisWebSocket
{
   
    public partial class WebSocket : Form
    {


        private Socket socket;
        private const int PORT_SERVER = 50000;
        private const int BUFFER_LEN = 256;
        private const int backlog = 10;
        private IPAddress ip;
        private string fname;
        Thread thr;
      //  private string host;
        byte[] buf;
        public WebSocket()
        {
            InitializeComponent();
        }

        private void WebSocket_Load(object sender, EventArgs e)
        {   try
            {
               
                buf = new byte[BUFFER_LEN];
                string host = Dns.GetHostName();
                ip = Dns.GetHostByName(host).AddressList[0];
                TBoxServerAddr.Text = ip.ToString();
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(ip, PORT_SERVER));
                socket.Listen(backlog);
                thr = new Thread(SendData);
                thr.IsBackground = true;
                thr.Start();


            }
            catch(SocketException ex)
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
        private delegate void InvDelegate(ref Socket newSock);
        private void MSent(ref Socket newSock)
        {
            try { 
                  string IpAddr = ((IPEndPoint)newSock.RemoteEndPoint).Address.ToString();
                    string PortAddr = ((IPEndPoint)newSock.RemoteEndPoint).Port.ToString();
                    var result = MessageBox.Show("New connection from " + IpAddr +
                        ":" + PortAddr,
                        "New Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                   
                    if (result != DialogResult.OK)
                    throw new Exception("Подключение прервано");
                    TBoxConnect.Text = IpAddr + ":" + PortAddr;
                        if (openFileDlg.ShowDialog() != DialogResult.OK)
                        throw new Exception("Подключение прервано");
                      
                            fname = openFileDlg.FileName;
                            TBoxFile.Text = fname;

                            int i = fname.Length-1;
                            while (fname[i]!='\\')
                            { --i; }
                            string shortname = fname.Substring(i+1);
                            buf[0] = (byte)shortname.Length;
                            for (int j = 0; j < buf[0]; j++)
                            buf[j + 1] = (byte)shortname[j];
                            newSock.Send(buf);

                            FileStream rdFile = new FileStream(fname, FileMode.Open, FileAccess.Read);
                            byte count = 0;
                            while ((count = (byte)rdFile.Read(buf, 1, BUFFER_LEN - 1)) != 0)
                            {
                                buf[0] = count;
                                newSock.Send(buf);
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

                    if (newSock != null)
                    {
                      
                        newSock.Close();
                        newSock = null;
                    }
                }

           
        }
        [STAThread]
        private void SendData()
        {
            Socket newSock = null;

            while (true)
            {
                try
                {
                    newSock = socket.Accept();
                    EndInvoke(BeginInvoke(new InvDelegate(MSent), newSock));
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {

                    
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
