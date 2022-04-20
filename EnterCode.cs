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
        //para generar el numero randomico y pasarlo a la variable codigo
        Random random = new Random();
        private int codigo;
        //para controlar la cantidad de veces que fallas al insertar el codigo
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
            //controla que lo que ingreses sea igual al codigo y la cantidad de veces que fallas
            //si fallas 3 veces el codigo cambia
            if (codigo.ToString() == tbEnterCode.Text)
            {
                NewPassword newPassword = new NewPassword();
                newPassword.Show();
                this.Hide();
            }
            else if(codigo.ToString() != tbEnterCode.Text && aux != 2)
            {
                MessageBox.Show("Ingrese el codigo correcto");
                aux++;
            }
            else if(codigo.ToString() != tbEnterCode.Text && aux == 2)
            {
                aux = 0;
                EnterRamdom();
                MessageBox.Show("Cambio el codigo");
            }
        }
        //genera el numero random y lo pasa a la variable codigo
        //tambien agregue un label auxiliar de momento para probar lo del codigo 
        //ese label muestra el codigo
        private void EnterRamdom()
        {
            codigo = random.Next(1000, 9999);
            lblAuxiliar.Text = codigo.ToString();
        }
        //este procedimiento sirve para que el email ingresado en el anterior forms aparezca aca
        public void enterEmail(string email)
        {
            lblComplete.Text = email;
        }
        
    }
}
