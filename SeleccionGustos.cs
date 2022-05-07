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
    public partial class SeleccionGustos : Form
    {
        public int cont = 0;

        public SeleccionGustos()
        {
            InitializeComponent();
            btnconfirm.Enabled = false;
            fill();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            parameters(Global1.array);
            MessageBox.Show("Usted se ha registrado exitosamente!!!");
            PrivateInterface inter = new PrivateInterface();
            inter.Show();
            this.Hide();
        }

        public static class Global1
        {
            public static int cont=0;
            public static string sConexion = Global.Conexion;
            public static SqlConnection dataConnection = new SqlConnection(sConexion);
            public static SqlDataAdapter da;
            public static int idCategory = 0;
            public static int[] array=new int[7];
            public static DataTable dt = new DataTable();

        }

        public void contar()
        {
            Global1.cont++;
            if (Global1.cont >= 3)
            {
                btnconfirm.Enabled = true;
            }
        }

        public void descontar()
        {
            Global1.cont--;
            if (Global1.cont <= 3)
            {
                btnconfirm.Enabled = false;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbThriller.Checked == true)
            {
                contar();
                arraySave(1);
            }
            else
            {
                descontar();
                arrayDelete(1);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArcade.Checked == true)
            {

                contar();
                arraySave(3);
            }
            else
            {
                descontar();
                arrayDelete(3);
            }
        }

        private void cbAction_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAction.Checked == true)
            {
                contar();
                arraySave(2);
            }
            else
            {
                descontar();
                arrayDelete(2);
            }
        }

        private void cbSports_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSports.Checked == true)
            {
                contar();
                arraySave(4);
            }
            else
            {
                descontar();
                arrayDelete(4);
            }
        }

        private void cbRPG_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRPG.Checked == true)
            {
                contar();
                arraySave(5);
            }
            else
            {
                descontar();
                arrayDelete(5);
            }
        }

        private void cbSimulators_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSimulators.Checked == true)
            {
                contar();
                arraySave(6);
            }
            else
            {
                descontar();
                arrayDelete(6);
            }
        }


        public void parameters(int[] idcat)
        {
            for (int i=0;i<Global1.array.Length; i++)
            {
                if (Global1.array[i] != 0)
                {
                    Global1.da = new SqlDataAdapter("SP_AddPreferences", Global1.dataConnection);
                    Global1.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Global1.da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
                    Global1.da.SelectCommand.Parameters.Add("@idCategory", SqlDbType.Int);
                    Global1.da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
                    Global1.da.SelectCommand.Parameters["@idCategory"].Value = i;
                    Global1.da.Fill(Global1.dt);
                }
                
            }
        }

        public void arraySave(int id)
        {
            Global1.array[id] = 1;
            Global.VectorGustos[id] = 1;

        }

        public void arrayDelete(int id)
        {
            Global1.array[id] = 0;
            Global.VectorGustos[id] = 0;

        }

        public void fill()
        {
            for(int i = 0; i < 7; i++)
            {
                Global1.array[i] = 0;
                Global.VectorGustos[i] = 0;
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
