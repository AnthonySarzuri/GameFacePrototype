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
    public partial class PublicInterface : Form
    {
        
        private int continuar;
        public PublicInterface()
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



            int count = int.Parse(dt.Rows[0][0].ToString());
            
            for (int i = 1; i <= count; i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1),this);
                publi.generarPostMostLikes();
                
                mainPanel.Controls.Add(publi.post);
                continuar = i + 1;
                if (i == 2)
                {
                    break;
                }
            }


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
            
            for (int i = continuar; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1),this);
                publi.generarPostMostLikes();
                mainPanel.Controls.Add(publi.post);
                continuar = i + 1;
                if (i % 2 == 0)
                {

                    break;
                }
            }

        }

        private void BTNIniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser(this);
            registerUser.Show();
            this.Enabled=false;
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
