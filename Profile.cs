using GameFacePrototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    public partial class Profile : Form
    {

        List<Posts> lisposts = new List<Posts>();

        public Profile()
        {
            InitializeComponent();
            generarPost();
        }
        //Generar Posts
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
            da.Fill(dt);


            int posicion = 0;
            int aux = 1000;

            for (int i = 1; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {

                Posts publi = new Posts(i, (i - 1), posicion);
                publi.generarPost();
                lisposts.Add(publi);
                PanelPrincipal.Controls.Add(publi.post);
                posicion = aux * i;
            }
        }



        private void btnComentarioPrueba_Click(object sender, EventArgs e)
        {
            CommentsTest commentsTest = new CommentsTest();
            commentsTest.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrivateInterface privateInterface = new PrivateInterface();
            privateInterface.Show();
            this.Hide();
        }

        private void btnEditProfilePicture_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            edit.Show();
            this.Hide();
            edit.FormClosing += Edit_FormClosing;
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            CreatePostTest createPostTest = new CreatePostTest();
            createPostTest.Show();
            this.Hide();
            createPostTest.FormClosing += Edit_FormClosing;
        }
    }
}
