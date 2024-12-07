using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Web.Script.Serialization;
using System.Drawing;
using System.Text;



namespace messanger_sayna
{
    public partial class Form1 : Form
    {

        TcpClient m_client;
        const int port = 1000;
        Thread listeningThread = null;

        //declare delegates
        public delegate void TrackBarDelegate(TrackBarDetails trackBarDetails);
        public delegate void AddMessageDelegate(string message);
       
        //declaring an event that is tied to the delegate
        public event TrackBarDelegate TrackBarEvent;
        public event AddMessageDelegate AddMessageEvent;
        // object of delegate
        TrackBarDelegate TD;
        // object of the structure 
        TrackBarDetails T;

        public Form1()
        {


            InitializeComponent();
            TrackBarEvent += new TrackBarDelegate(UpdateDetails);
            AddMessageEvent += new AddMessageDelegate(AddMessage);
            chatMessages = new ChatMessage();
            //chatMessages = new ChatMessages():
            //    AddMessageEvent += new AddMessageDelegate(AddMessage); 
        }


        public struct TrackBarDetails //struct for controls variables
        {
            public int Value;
        }

        public struct ChatMessage
        {
            public string UserName;
            public string MessageText;
            public double Value;
        }
        ChatMessage chatMessages;

        public void AddMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddMessageDelegate(AddMessage),new object[] {message});
            }

            else
            {
               JavaScriptSerializer serializer = new JavaScriptSerializer();       
               ChatMessage chatMessages = serializer.Deserialize<ChatMessage>(message);

                textMessage.AppendText(DateTime.Now.ToString() + ": ");
                textMessage.AppendText(chatMessages.UserName);
                textMessage.AppendText(": ");
                textMessage.AppendText(chatMessages.MessageText);
                textMessage.AppendText(Environment.NewLine);

                dataGrid.Rows.Add(new object[] {chatMessages.UserName, chatMessages.MessageText, DateTime.Now.ToString() });

                JSONBox.AppendText("Message sent by:" + chatMessages.UserName + " : " + "Track bar Value" + chatMessages.Value.ToString());
                JSONBox.AppendText(Environment.NewLine);
                JSONBox.AppendText(message);
                
            }
        }

       

        //this  method will be tied to the deligate
        //this serilizes the message
        public void UpdateDetails(TrackBarDetails value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new TrackBarDelegate ( UpdateDetails), new object[] { value });
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
               // serializing the value
                 string jsonString = serializer.Serialize(value);
               
                JSONBox.AppendText("update Deigate in the client" + jsonString);
                JSONBox.AppendText(Environment.NewLine);
            }
        }

        //this is the event that will triger the deligate
        private void TBarClient_Scroll_1(object sender, EventArgs e)
        {
            //declaring a vaklue to the scroll bar value
            int value = this.TBarClient.Value;
            BTNValue.Text = value.ToString();
            //update the type structure member value
            T.Value = value;
            ////assign the function to the deligate
            //TD = new TrackBarDelegate(UpdateDetails);
            ////calling deligate and then it calls function
            //TD(T);
            // Fire an Event
            TrackBarEvent?.Invoke(T);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            m_client = new TcpClient();
            IPAddress ip = IPAddress.Parse(IPAdressText.Text);
            
            m_client.Connect(ip, port);

            MessageBox.Show("Connected to: " + IPAdressText.Text);
            //starts listening for received messages on new thread

            listeningThread = new Thread(new ThreadStart(Listen));
            listeningThread.Start();
        }

        private void Listen()
        {
            //client is recieveiong a stream of data
            NetworkStream stream = m_client.GetStream();

            while (true)
            {
                //array called buffer of bytes that has been received
                byte[] buffer = new byte[255];
                //convert the stream of byte to int
                int num_byte = stream.Read(buffer, 0, 255);
                //if the int becomes 0 that means there are no data receiving
            
            if(num_byte > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer,0,num_byte);
                    AddMessageEvent.Invoke(message);
                }
            }
            
        }

        private void MessageText_TextChanged(object sender, EventArgs e)
        {
            txtSend.ForeColor = Color.Black;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //to send text
            NetworkStream stream;
            try
            {


                chatMessages.UserName = UsernameText.Text;
                chatMessages.MessageText = txtSend.Text;
                chatMessages.Value = TBarClient.Value;

                //serializing the message
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                string jsonMessege = Serializer.Serialize(chatMessages);

                stream = m_client.GetStream();
                byte[] rawData = Encoding.ASCII.GetBytes(jsonMessege);
                stream.Write(rawData, 0, rawData.Length);

                AddMessageEvent?.Invoke(jsonMessege);
            }

            catch(Exception exp)
            {
                MessageBox.Show("Exception Thrown: " + exp.Message);
            }
            
        }
    }
}
