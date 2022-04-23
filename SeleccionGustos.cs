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
    public partial class SeleccionGustos : Form
    {
        public int cont = 0;
        public bool img1 = false;
        public bool img2 = false;
        public bool img3 = false;
        public bool img4 = false;
        public bool img5 = false;
        public bool img6 = false;
        public bool img7 = false;
        public bool img8 = false;
        public bool img9 = false;

        public SeleccionGustos()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (cont == 3)
            {
                MessageBox.Show("SE REGISTRARON TUS GUSTOS CON EXITO :)");

                this.Close();
                PrivateInterface inter = new PrivateInterface();
                inter.Show();

            }
            else
            {
                MessageBox.Show("TE FALTAN CATEGORIAS POR SELECCIONAR");
            }
        }

        public void validarImg(bool var)
        {
            if (var == false)
            {
                var = true;
                cont++;

            }
            else
            {
                var = false;
                cont = cont - 1;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (img1 == false)
            {
                img1 = true;
                cont++;

            }
            else
            {
                img1 = false;
                cont = cont - 1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (img2 == false)
            {
                img2 = true;
                cont++;

            }
            else
            {
                img2 = false;
                cont = cont - 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (img3 == false)
            {
                img3 = true;
                cont++;

            }
            else
            {
                img3 = false;
                cont = cont - 1;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (img6 == false)
            {
                img6 = true;
                cont++;

            }
            else
            {
                img6 = false;
                cont = cont - 1;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (img5 == false)
            {
                img5 = true;
                cont++;

            }
            else
            {
                img5 = false;
                cont = cont - 1;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (img4 == false)
            {
                img4 = true;
                cont++;

            }
            else
            {
                img4 = false;
                cont = cont - 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (img9 == false)
            {
                img9 = true;
                cont++;

            }
            else
            {
                img9 = false;
                cont = cont - 1;
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (img8 == false)
            {
                img8 = true;
                cont++;

            }
            else
            {
                img8 = false;
                cont = cont - 1;
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (img7 == false)
            {
                img7 = true;
                cont++;

            }
            else
            {
                img7 = false;
                cont = cont - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Global.IdUser.ToString(); 
        }
    }
}
