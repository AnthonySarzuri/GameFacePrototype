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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_LOGIN", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                da.SelectCommand.Parameters.Add("@NickNameorEmail", SqlDbType.NVarChar, 50);
                da.SelectCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@NickNameorEmail"].Value = tbUser.Text;
                da.SelectCommand.Parameters["@Password"].Value = tbPassword.Text;

                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    //Aqui di la vuelata la parte donde se declara el Login y la parte donde se declara la pantalla de PrivateInterface 
                    //para que el login se declare antes de que se habra la siguiente pantalla lo necesitaba para que funcionen los posts
                    //pero si necesitan que este al reves por alguna razón entonces solo vuelvanlo a poner debajo eso es todo xd
                    int iduser;
                    iduser = (int)(dt.Rows[0][0]);
                    Global.IdUser = iduser;


                    PrivateInterface inter = new PrivateInterface();
                    inter.Show();
                    this.Hide();                  
                   
                }
                else
                {
                    lblError.Text = "Su usuario o contraseña son incorrectos, revise por favor";
                    tbPassword.Text = "";
                    Global.tries++;
                }
                if (Global.tries >= 3)
                {
                    MessageBox.Show("Número de intentos de inicio de sesión superado.");
                    btnLogin.Enabled = false;
                    timerOut.Start();
                    //Global.sec = 5;
                    Global.cont = 0;
                }


            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error","Lo Sentimos :(");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.Show();
            this.Hide();
        }

        private void lblPasswordGet_Click(object sender, EventArgs e)
        {
            EnterEmail enterEmail = new EnterEmail();   
            enterEmail.Show();
            this.Hide();
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            Global.cont += 1;
            if (Global.cont == 5 * Global.cont2)
            {
                timerOut.Stop();
                btnLogin.Enabled = true;
                Global.cont2++;
                Global.tries = 0;
                Global.cont = 0;
            }
        }
    }
}
