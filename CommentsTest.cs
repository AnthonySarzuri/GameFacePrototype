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
    public partial class CommentsTest : Form
    {
        public CommentsTest()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CreateComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@commentary", SqlDbType.NVarChar, 250);
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            
            da.SelectCommand.Parameters["@commentary"].Value = txtcommentary.Text;
            da.SelectCommand.Parameters["@idUser"].Value = 1;
            da.SelectCommand.Parameters["@idPost"].Value = 1;

            da.Fill(dt);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_DeleteComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = 1;
            da.SelectCommand.Parameters["@IdPost"].Value = 1;
            da.SelectCommand.Parameters["@Id"].Value = 1;

            da.Fill(dt);
        }
    }
}
