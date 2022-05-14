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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        //de momento solo valida que los campos sean iguales cuando tengamos la base de datos agregare mas validaciones
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ForgotPassword", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {

                da.SelectCommand.Parameters.Add("@Mail", SqlDbType.NVarChar, 50);
                da.SelectCommand.Parameters.Add("@Pass", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@Mail"].Value = Global.mailer;
                da.SelectCommand.Parameters["@Pass"].Value = tbRepeatNewPassword.Text;

                da.Fill(dt);

                if (tbNewPassword.Text == tbRepeatNewPassword.Text)
                {
                    MessageBox.Show("La contraseña se cambio correctamente");
                    this.Close();
                    Login logeo = new Login();
                    logeo.Show();
                }
                else
                {
                    MessageBox.Show("Los campos no coinciden");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }
    }
}
