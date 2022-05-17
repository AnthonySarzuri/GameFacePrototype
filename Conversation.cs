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

using System.Data.SqlClient;

namespace GameFacePrototype
{
    public partial class Conversation : Form
    {
        private int idFriend;
        private int postCount;
        private int continuar;
        private int pos;

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
            generarMasMensajes();
        }

        public Conversation(int idFriend)
        {
            InitializeComponent();
            conectar_server();
            this.idFriend = idFriend;
            generarMensajes();
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
                //192.168.120.220
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
        private void generarMasMensajes()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountMessages", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idFriend", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

            int id = idFriend;
            da.SelectCommand.Parameters["@idFriend"].Value = idFriend;


            da.Fill(dt);


            int count = int.Parse(dt.Rows[0][0].ToString());
           
            if(postCount< int.Parse(dt.Rows[0][0].ToString()))
            {
                for (int i = continuar; i <= count; i++)
                {
                    Messages message = new Messages((i - 1), id);
                    message.generarComentarios();
                    panelChat.Controls.Add(message.comment);
                    continuar = i + 1;
                    postCount = int.Parse(dt.Rows[0][0].ToString());
                }
            }
            
        }
        private void generarMensajes()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountMessages", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idFriend", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

            int id = idFriend;
            da.SelectCommand.Parameters["@idFriend"].Value =idFriend;
            

            da.Fill(dt);


            int count = int.Parse(dt.Rows[0][0].ToString());
            postCount = int.Parse(dt.Rows[0][0].ToString());
            for (int i = 1; i <= count; i++)
            {
                Messages message = new Messages( (i - 1), id);
                message.generarComentarios();
                panelChat.Controls.Add(message.comment);

                continuar = i + 1;
            }
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
            insertarMensaje(txtMensaje.Text);
            streamw.WriteLine(txtMensaje.Text);
            streamw.Flush();
            txtMensaje.Clear();

        }
        private void insertarMensaje(string mensaje)
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_SaveMessages", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Message", SqlDbType.NVarChar,500);
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdDestinyUser", SqlDbType.Int);


            da.SelectCommand.Parameters["@Message"].Value = mensaje;
            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@IdDestinyUser"].Value = idFriend;


            da.Fill(dt);
        }
    }
}
