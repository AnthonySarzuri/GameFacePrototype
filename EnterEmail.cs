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
    public partial class EnterEmail : Form
    {
        public EnterEmail()
        {
            InitializeComponent();
        }
        //Valida que el campo no este vacio
        //cuando tengamos la base aumentare las demas validaciones
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (tbEnterEmail.Text !="")
            {
                EnterCode enterCode = new EnterCode();
                enterCode.Show();
                enterCode.enterEmail(tbEnterEmail.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Rellene el campo con un correo electronico valido");
            }
            
        }
    }
}
