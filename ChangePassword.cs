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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCloseRegisterUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.Conexion);
            SqlDataAdapter Adpt = new SqlDataAdapter("SP_SelectPassById", con);
            con.Open();
            Adpt.SelectCommand.CommandType = CommandType.StoredProcedure;

            Adpt.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
            Adpt.SelectCommand.Parameters["@id"].Value = Global.IdUser;

            DataSet passwords = new DataSet();
            Adpt.Fill(passwords);

            for (int j = 0; j < passwords.Tables[0].Rows.Count; j++)
            {
                if (tbIntroducePassword.Text == passwords.Tables[0].Rows[j]["Pass"].ToString())
                {
                    j = passwords.Tables[0].Rows.Count;
                    btnChangePassword.Text = "Cambiar Contraseña";
                    tbNewPassword.ReadOnly = false;
                    tbRepeatPassword.ReadOnly = false;

                    bool pswEval = true;
                    if (pswEval == true)
                    {
                        for (int i = 0; i <= tbNewPassword.Text.Length - 1; i++)
                        {
                            if (tbNewPassword.Text[i] == ' ')
                            {
                                MessageBox.Show("Error, la contraseña no debe contener espacios");
                                i = tbNewPassword.Text.Length;
                                pswEval = false;
                            }
                        }
                    }
                    if (pswEval == true)
                    {
                        if (tbNewPassword.Text != "" && tbRepeatPassword.Text != "")
                        {
                            if (tbNewPassword.Text == tbRepeatPassword.Text)
                            {
                                DataTable dt = new DataTable();

                                SqlConnection dataConnection = new SqlConnection(Global.Conexion);
                                SqlDataAdapter da = new SqlDataAdapter("SP_ChangePassword", dataConnection);
                                dataConnection.Open();
                                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
                                da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

                                da.SelectCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                                da.SelectCommand.Parameters["@Password"].Value = tbNewPassword.Text;

                                da.Fill(dt);

                                MessageBox.Show("Contraseña actualizada");

                                EditProfile EditPro = new EditProfile();
                                EditPro.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Error, las contraseñas no coinciden, por favor intente nuevamente");
                            }

                        }

                        else
                        {
                            MessageBox.Show("Ingrese su nueva contraseña");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }

        private void btnSHPassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.PasswordChar == '*')
            {

                tbIntroducePassword.PasswordChar = '\0';
                tbNewPassword.PasswordChar = '\0';
                tbRepeatPassword.PasswordChar = '\0';
            }
            else
            {
                tbIntroducePassword.PasswordChar = '*';
                tbNewPassword.PasswordChar = '*';
                tbRepeatPassword.PasswordChar = '*';
            }
        }
    }
}
