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
    public partial class AddReaction : Form
    {
        public AddReaction()
        {
            InitializeComponent();
        }

        private void BTNaddReaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TBreaction.Text))
                {
                    MessageBox.Show("Ingrese todos los campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TBreaction.Text.Length < 3)
                {
                    MessageBox.Show("El nombre de la categoría ingresado es muy pequeño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    addReaction();
                    MessageBox.Show("Reacción añadida con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void addReaction()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_AddReaction", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@reaction", SqlDbType.NVarChar, 10);

            da.SelectCommand.Parameters["@reaction"].Value = TBreaction.Text;

            da.Fill(dt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Close();
        }
    }
}
