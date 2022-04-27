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
    public partial class PrivateInterface : Form
    {
        
        public PrivateInterface()
        {
            
            InitializeComponent();
            generarPost();
            lastConnected();
            
        }
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;

            da.Fill(dt);

            int global = Global.IdUser;
            int posicion = 0;
            int aux = 900;
            int count = int.Parse(dt.Rows[0][0].ToString());

            for (int i = 1; i <=count ; i++)
            {
                Posts publi = new Posts(i, (i - 1), posicion);
                publi.generarPostFriend();
                mainPanel.Controls.Add(publi.post);
                posicion = aux * i;
            }
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }
        private void lastConnected()
        {
            this.FormClosing += CreatePostTest_FormClosing;
        }

        private void CreatePostTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_LastConnected", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUser;

            da.Fill(dt);
        }

        private void bntProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
            profile.FormClosing += Profile_FormClosing;
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
