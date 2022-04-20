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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnCloseRegisterUser_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }
        //Se agregaran más validaciones cuando usemos la BD
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegisterEmail.Text) || string.IsNullOrEmpty(tbRegisterUserName.Text) ||
                string.IsNullOrEmpty(tbRegisterPassword.Text) || string.IsNullOrEmpty(tbRegisterConfirmPassword.Text))
            {
                MessageBox.Show("Ingrese todos los campos obligatorios.");
            }
            else if (tbRegisterPassword.Text != tbRegisterConfirmPassword.Text)
            {
                MessageBox.Show("Los campos 'Contraseña' y  'Confirmar Contraseña'\n" +
                    "deben tener los mismos valores");
            }
            else 
            {
                //Aquí le cambiomos para ir a registrar gustos en ves de este Message box : )
                MessageBox.Show("Usuario registrado exitosamente");
            }
        }
    }
}
