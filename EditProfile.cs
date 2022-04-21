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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
            TBUserEdit.Text = "Escriba su nombre aqui";
            TBPhoneEdit.Text = "Escriba su Telefono Aqui";
            TBBirthEdit.Text = "Escriba su Fecha de Nacimiento";
            TBMailEdit.Text = "Escriba su Correo";
        }



        private void TBUserEdit_TextChanged(object sender, EventArgs e)
        {
            TBUserEdit.Text = "";
            string usuario = "";
            usuario = TBUserEdit.Text;
        }

        private void TBPhoneEdit_TextChanged(object sender, EventArgs e)
        {
            TBPhoneEdit.Text = "";
            string phone = "";
            phone = TBPhoneEdit.Text;
        }

        private void TBBirthEdit_TextChanged(object sender, EventArgs e)
        {
            TBBirthEdit.Text = "";
            string birth = "";
            birth = TBBirthEdit.Text;
        }

        private void TBMailEdit_TextChanged(object sender, EventArgs e)
        {
            TBBirthEdit.Text = "";
            string mail = "";
            mail = TBBirthEdit.Text;
        }

        private void BTNPasswordChange_Click(object sender, EventArgs e)
        {
            //ChangePassword Change = new ChangePassword();
            //Change.Show();
        }
    }
}
