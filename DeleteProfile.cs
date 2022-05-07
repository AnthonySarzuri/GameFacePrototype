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
    public partial class DeleteProfile : Form
    {
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarUsuario();
                MessageBox.Show("Hasta luego.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception E) 
            {
                MessageBox.Show("Ocurrió un error.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            edit.Show();
            this.Hide();
        }

        //Método para "eliminar" un perfil - usuario

        private void eliminarUsuario() 
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_DeleteUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);

            da.SelectCommand.Parameters["@Id"].Value = Global.IdUser;

            da.Fill(dt);
        }
    }
}
