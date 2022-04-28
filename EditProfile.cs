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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        //Ir a cambiar contraseña

        private void BTNPasswordChange_Click(object sender, EventArgs e)
        {
            ChangePassword Change = new ChangePassword();
            Change.Show();
            this.Hide();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            DeleteProfile delete = new DeleteProfile();
            delete.Show();
            this.Hide();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBUserEdit.Text) && string.IsNullOrEmpty(TBPhoneEdit.Text) &&
                string.IsNullOrEmpty(TBMailEdit.Text) && string.IsNullOrEmpty(TBBiographyEdit.Text))
            {
                MessageBox.Show("Ingrese al menos un campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!TBMailEdit.Text.Contains("@gmail.com") && !string.IsNullOrEmpty(TBMailEdit.Text))
            {
                MessageBox.Show("No es un correo electrónico valido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TBUserEdit.Text.Length < 3 && !string.IsNullOrEmpty(TBUserEdit.Text))
            {
                MessageBox.Show("El nombre de usuario ingresado es muy pequeño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                try
                {
                    editarPerfil();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Ocurrió un error.");
                }
            }
        }

        private void TBPhoneEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Método para editar perfil

        private void editarPerfil() 
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_EditProfile", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@userName", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@mobile", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@birthDate", SqlDbType.Date);
            da.SelectCommand.Parameters.Add("@email", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@profilePicture", SqlDbType.Image);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@userName"].Value = TBUserEdit.Text;
            da.SelectCommand.Parameters["@mobile"].Value = TBPhoneEdit.Text;
            da.SelectCommand.Parameters["@birthDate"].Value = DTPbirthday.Value;
            da.SelectCommand.Parameters["@email"].Value = TBMailEdit.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            PBProfilePicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            da.SelectCommand.Parameters["@profilePicture"].Value = ms.GetBuffer();

            da.Fill(dt);
        }

        //Método para importar imágenes por el explorador de archivos

        private void PBProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Filtros de imágenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PBProfilePicture.Image = new Bitmap(open.FileName);
            }
        }

        //Verificación de ingreso de fecha válida

        private void DTPbirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (DTPbirthday.Value.AddYears(13) >= hoy)
            {
                MessageBox.Show("Fecha de cumpleaños no válida, debes ser de 13 años o mayor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DTPbirthday.Value = hoy.AddYears(-13);
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPreferences editpref = new EditPreferences();
            editpref.Show();
            this.Close();
        }
    }
}
