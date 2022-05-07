using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameFacePrototype
{
    public partial class EditPreferences : Form
    {
        public EditPreferences()
        {
            
            InitializeComponent();
            ObtenerGustos();
            fill();
            CheckPreferences();
            

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            
            deletePreferences();
            parameters(Global1.array);

            MessageBox.Show("Se editó con Éxito", "Épico");
            this.Close();
            EditProfile editp = new EditProfile();
            editp.Show();
        }

        private void ObtenerGustos()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("[SP_SelectPreferences]", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

            da.Fill(dt);

            int NumRegistros = (dt.Rows.Count);

            for(int i = 0; i < NumRegistros; i++)
            {
                Global.VectorGustos[i] = (int)(dt.Rows[i][0]);
            }

        }

        private void CheckPreferences()
        {
            for(int i = 0; i < 7; i++)
            {
                switch (Global.VectorGustos[i])
                {
                    case 1:
                        {
                            cbThriller.Checked = true;
                            //arraySave(1);
                            Global1.array[1] = 1;
                            break;
                        }
                    case 2:
                        {
                            cbAction.Checked = true;
                            Global1.array[2] = 1;
                            break;
                        }
                    case 3:
                        {
                            cbArcade.Checked = true;
                            Global1.array[3] = 1;
                            break;
                        }
                    case 4:
                        {
                            cbSports.Checked = true;
                            Global1.array[4] = 1;
                            break;
                        }
                    case 5:
                        {
                            cbRPG.Checked = true;
                            Global1.array[5] = 1;
                            break;
                        }
                    case 6:
                        {
                            cbSimulators.Checked = true;
                            Global1.array[6] = 1;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                    
            }
        }

        public static class Global1
        {
            public static int cont = 0;
            public static string sConexion = Global.Conexion;
            public static SqlConnection dataConnection = new SqlConnection(sConexion);
            public static SqlDataAdapter da;
            public static int idCategory = 0;
            public static int[] array = new int[7];
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

        private void cbThriller_CheckedChanged(object sender, EventArgs e)
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

        private void cbArcade_CheckedChanged(object sender, EventArgs e)
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
            for (int i = 0; i < Global1.array.Length; i++)
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

        public void fill()
        {
            for (int i = 0; i < 7; i++)
            {
                Global1.array[i] = 0;
            }
        }

        public void arraySave(int id)
        {
            Global1.array[id] = 1;
            

        }

        public void arrayDelete(int id)
        {
            Global1.array[id] = 0;
            

        }

        public void deletePreferences()
        {
            
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_DeletePreference", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

            da.Fill(dt);
        }

    }
}
