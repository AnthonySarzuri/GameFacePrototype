using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    public partial class Form1 : Form
    {
        
        private int continuar;
        public Form1()
        {
            InitializeComponent();
            generarPost();
        }
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostMostLikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@numLikes", SqlDbType.Int);
            da.SelectCommand.Parameters["@numLikes"].Value = 5;

            da.Fill(dt);


            int posicion = 0;
            int aux = 1100;
            int count = int.Parse(dt.Rows[0][0].ToString());
            
            for (int i = 1; i <= count; i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1), posicion,this);
                publi.generarPostMostLikes();
                
                mainPanel.Controls.Add(publi.post);
                posicion = aux * i;
                continuar = i + 1;
                if (i == 2)
                {
                    break;
                }
            }
            Global.posicionPost = 0;

        }
        private void newPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostMostLikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@numLikes", SqlDbType.Int);
            da.SelectCommand.Parameters["@numLikes"].Value = 5;

            da.Fill(dt);

            int posicion = 1100;
            int aux = 1100;
            int count = 1;
            
            for (int i = continuar; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1), posicion,this);
                publi.generarPostMostLikes();
                mainPanel.Controls.Add(publi.post);
                count++;
                posicion = aux * count;
                continuar = i + 1;
                if (i % 2 == 0)
                {

                    break;
                }
            }
            Global.posicionPost = 0;
        }

        private void BTNIniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Enabled = false;
            login.FormClosing += LoginRegister_FormClosing;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser(this);
            registerUser.Show();
            this.Enabled=false;
            registerUser.FormClosing += LoginRegister_FormClosing;
        }

        private void LoginRegister_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Enabled=true;
        }

        private void btnShowMorePost_Click(object sender, EventArgs e)
        {
            newPost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
