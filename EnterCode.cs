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
    public partial class EnterCode : Form
    {
        Random random = new Random();
        private int rand;
        private int aux;
        public EnterCode()
        {
            InitializeComponent();
            EnterRamdom();
        }

        private void EnterCode_Load(object sender, EventArgs e)
        {

        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {

          

            if (rand.ToString() == tbEnterCode.Text && aux!=2)
            {
                NewPassword newPassword = new NewPassword();
                newPassword.Show();
                this.Hide();
            }
            else if(rand.ToString() != tbEnterCode.Text && aux != 2)
            {
                MessageBox.Show("Ingrese el codigo correcto");
                aux++;
            }
            else if(aux == 2)
            {
                aux = 0;
                EnterRamdom();
                MessageBox.Show("Cambio el codigo");
            }
        }
        private void EnterRamdom()
        {
            rand = random.Next(1000, 9999);
            lblAuxiliar.Text = rand.ToString();
        }

        public void enterEmail(string email)
        {
            lblComplete.Text = email;
        }
        
    }
}
