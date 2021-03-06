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
    public partial class RegisterUser : Form
    {
        Form formulario;
        static Random random = new Random();
        int numAuto = random.Next(0001,10000);

        public RegisterUser()
        {
            InitializeComponent();
        }
        public RegisterUser(Form formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }
        private void btnCloseRegisterUser_Click(object sender, EventArgs e)
        {
            formulario.Enabled = true;
            this.Close();
            
        }

        //Se agregaran más validaciones cuando usemos la BD

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegisterEmail.Text) || string.IsNullOrEmpty(tbRegisterUserName.Text) ||
                string.IsNullOrEmpty(tbRegisterPassword.Text) || string.IsNullOrEmpty(tbRegisterConfirmPassword.Text))
            {
                MessageBox.Show("Ingrese todos los campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbRegisterPassword.Text != tbRegisterConfirmPassword.Text)
            {
                MessageBox.Show("Los campos 'Contraseña' y  'Confirmar Contraseña'\n" +
                    "deben tener los mismos valores", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!tbRegisterEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("No es un correo electrónico valido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbRegisterUserName.Text.Length < 3)
            {
                MessageBox.Show("El nombre de usuario ingresado es muy pequeño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbRegisterPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña ingresada es muy pequeña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbRegisterCellphoneNumber.Text.Length < 7 && !string.IsNullOrEmpty(tbRegisterCellphoneNumber.Text)) 
            {
                MessageBox.Show("El número de celular ingresado es muy pequeño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                try
                {
                    registarUsuario();
                    obtenerId();
                    try
                    {
                        formulario.Hide();
                    }
                    catch
                    {

                    }
                    SeleccionGustos seleccionGustos = new SeleccionGustos();
                    seleccionGustos.Show();
                    this.Hide();

                }
                catch (Exception E)
                {
                    MessageBox.Show("Ocurrió un error.");
                }
            }
        }

        //Método para el registro del usuario

        private void registarUsuario()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_NewUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@email", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@mobile", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.NVarChar, 50);

            da.SelectCommand.Parameters["@email"].Value = tbRegisterEmail.Text;
            da.SelectCommand.Parameters["@mobile"].Value = tbRegisterCellphoneNumber.Text;
            da.SelectCommand.Parameters["@username"].Value = tbRegisterUserName.Text;
            da.SelectCommand.Parameters["@password"].Value = tbRegisterPassword.Text;
            da.SelectCommand.Parameters["@idUser"].Value = tbRegisterUserName.Text.Substring(0, 3) + numAuto;

            da.Fill(dt);
            numAuto++;
        }

        private void obtenerId()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_GetId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                da.SelectCommand.Parameters.Add("@Mail", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@Mail"].Value = tbRegisterEmail.Text;


                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    int iduser;
                    iduser = (int)(dt.Rows[0][0]);
                    Global.IdUser = iduser;
                }
                


            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }

        private void tbRegisterCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegisterToSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login(formulario);
            login.Show();
            this.Hide();
        }
    }
}