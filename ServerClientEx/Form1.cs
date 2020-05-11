using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerClientEx
{
    public partial class ServerForm : Form
    {

        public bool exitStatus = false;
        public const int BYTE_SIZE = 1024;
        public const int PORT_NUMBER = 8888;
        
        // listens for and accept incoming connection requests
        private TcpListener serverListener;
        // TcpClient is used to connect with the TcpListener object
        private TcpClient serverSocket;
        // set up data stream object
        private NetworkStream netStream;
        // set up thread to run ReceiveStream() method
        private Thread serverThread = null;
        // set up delegate 
        // a delegate is a reference variable to a method
        // and used for a call back by the delegate object
        // delegate ref variable is declared in SetText() method below
        delegate void SetTextCallback(string text);
        public ServerForm()
        {
            InitializeComponent();

            // clear all text boxes
            txtboxSysMsg.Text = "Error messages appear here...";
            txtboxSend.Text = "Enter text here and press send button...";
            txtboxReceive.Text = "";
            // run server
            StartServer();
        }

        private void StartServer()
        {
            try
            {
                // create listener and start
                serverListener = new TcpListener(IPAddress.Loopback, PORT_NUMBER);
                serverListener.Start();
                // create acceptance socket
                // this creates a socket connection for the server
                serverSocket = serverListener.AcceptTcpClient();
                // create stream
                netStream = serverSocket.GetStream();
                // set up thread to run ReceiveStream() method
                serverThread = new Thread(ReceiveStream);
                // start thread
                serverThread.Start();
                txtboxReceive.Text = "Server started..." + Environment.NewLine;
            }
            catch (Exception e)
            {
                // display exception message
                txtboxSysMsg.Text = e.StackTrace;
            }
        }

        public void ReceiveStream()
        {
            byte[] bytesReceived = new byte[BYTE_SIZE];
            // loop to read any incoming messages
            while (!exitStatus)
            {
                try
                {
                    int bytesRead = netStream.Read(bytesReceived, 0, bytesReceived.Length);
                    this.SetText(Encoding.ASCII.GetString(bytesReceived, 0, bytesRead));
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("Client has exited!");
                    exitStatus = true;
                }
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // if these threads are different, it returns true.
            if(this.txtboxReceive.InvokeRequired)
            {
                // d is a Delegate reference to the SetText() method
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtboxReceive.Text += "Client: " + text + Environment.NewLine;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // send message in txtboxSend if any text present
            if (txtboxSend.Text.Length > 0)
            {
                // construct byte array to stream in write mode
                String strToSend = txtboxSend.Text;
                byte[] bytesToSend = Encoding.ASCII.GetBytes(strToSend);
                netStream.Write(bytesToSend, 0, bytesToSend.Length);
                    
                txtboxReceive.Text += "Server: " + strToSend + Environment.NewLine;
                txtboxSend.Text = "";
            }
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // terminate thread if still running
            if(serverThread.IsAlive)
            {
                Console.WriteLine("Server thread is alive");
                serverThread.Interrupt();
                if(serverThread.IsAlive)
                {
                    Console.WriteLine("Server thread is now terminated");
                }
            }
            else
            {
                Console.WriteLine("Server thread is terminated");
            }
            // close the application for good
            Environment.Exit(0);
        }
    }
}
