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
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@idPost"].Value = 1;

            da.Fill(dt);

            SqlDataAdapter da1 = new SqlDataAdapter("SP_SelectComment", dataConnection);
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da1.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

            da1.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
            da1.SelectCommand.Parameters["@idPost"].Value = 1;

            da1.Fill(dt);

            if (dt.Rows.Count >= 1)
            {

                int idcomment;
                idcomment = (int)(dt.Rows[0][0]);
                Global.IdComment = idcomment;
            }

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

            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@IdPost"].Value = 1;
            da.SelectCommand.Parameters["@Id"].Value = Global.IdComment;

            da.Fill(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Global.IdComment.ToString();
        }
    }
}
