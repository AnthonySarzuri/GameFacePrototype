using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (tbNewPassword.Text == tbRepeatNewPassword.Text)
            {
                MessageBox.Show("La contraseña se cambio correctamente");
            }
            else
            {
                MessageBox.Show("Los campos no coinciden");
            }
        }
    }
}
