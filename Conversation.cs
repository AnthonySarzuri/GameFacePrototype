using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using Transitions;
using System.Data.SqlClient;

namespace GameFacePrototype
{
    public partial class Conversation : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient ();
        static private string nick = "unknown";
        private string nombre;
        private delegate void DaddItem(string s);

        private void AddItem(string s)
        {                     
            listBox1.Items.Add(s);             
        }

        public Conversation()
        {
            InitializeComponent();
            conectar_server();
        }
        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(AddItem), streamr.ReadLine());
                }
                catch
                {
                    MessageBox.Show("no se pudo conectar al servidor");
                    Application.Exit();
                }
            }
        }
        void Conectar()
        {
            try
            {
                client.Connect("192.168.0.104", 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no Disponible");
                }
              }
            catch(Exception ex)
            {
                MessageBox.Show("servidor no disponible");
            }
          }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void showUserData()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowUserId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
               
               nombre= dt.Rows[0]["UserName"].ToString();
                
               
            }
            else
            {
                MessageBox.Show("Datos No Encontrados");
            }
        }
        private void conectar_server()
        {
            showUserData();
            nick = nombre;
            Conectar();

        }


        private void btn_send_Click(object sender, EventArgs e)
        {

            streamw.WriteLine(txtMensaje.Text);
            streamw.Flush();
            txtMensaje.Clear();

        }
    }
}
