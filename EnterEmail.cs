using Microsoft.VisualBasic;
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
            Global.mailer = tbEnterEmail.Text;
            DialogResult result = DialogResult.OK;
            do
            {
                SendMail mail = new SendMail();
                int code = mail.Send(tbEnterEmail.Text, "happyfridayxd@gmail.com", "xdCOD234");
                int resultado = 0;
                if (code != 0)
                {
                    try
                    {
                        resultado = Convert.ToInt32(Interaction.InputBox("Ingrese el codigo que fue enviado a:" + Global.mailer, "VERIFICACION"));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingrese una direccion de correo valida");
                        result = MessageBox.Show("¿Desea reenviar el correo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    if (code == resultado)
                    {
                        NewPassword neo = new NewPassword();
                        this.Close();
                        neo.Show();
                    }
                }
                else
                {
                    result = MessageBox.Show("¿Desea reenviar el correo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            } while (result == DialogResult.Yes);

        }
    }
}
