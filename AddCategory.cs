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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TBCategoryName.Text) || string.IsNullOrEmpty(TBCategoryDescription.Text))
                {
                    MessageBox.Show("Ingrese todos los campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TBCategoryName.Text.Length < 3)
                {
                    MessageBox.Show("El nombre de la categoría ingresado es muy pequeño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TBCategoryDescription.Text.Length < 10)
                {
                    MessageBox.Show("La descripción ingresada es muy pequeña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    addCategory();
                    MessageBox.Show("Categoría añadida con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void addCategory()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_AddCategory", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Category", SqlDbType.NVarChar, 20);
            da.SelectCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 150);

            da.SelectCommand.Parameters["@Category"].Value = TBCategoryName.Text;
            da.SelectCommand.Parameters["@Description"].Value = TBCategoryDescription.Text;

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
