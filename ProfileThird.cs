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
    public partial class ProfileThird : Form
    {
        
        public ProfileThird()
        {
            InitializeComponent();
            try
            {
                showUserData();
                generarPost();
                
            }
            catch (Exception E) 
            {
                
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showUserData() 
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowUserId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUserThird;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                LBLShowUserId.Text = dt.Rows[0]["IdUser"].ToString();
                LBLShowUser.Text = dt.Rows[0]["UserName"].ToString();
                LBLShowBirthday.Text = dt.Rows[0]["Birthday"].ToString();
                LBLShowBiography.Text = dt.Rows[0]["Biography"].ToString();
                Byte[] myByte = new byte[0];
                myByte = (Byte[])(dt.Rows[0]["ProfilePhoto"]);
                MemoryStream ms = new MemoryStream(myByte);
                PBProfilePicture.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Datos No Encontrados");
            }
        }
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUserThird;
            da.Fill(dt);


            int posicion = 0;
            int aux = 1100;

            for (int i = 1; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {

                Posts publi = new Posts(Global.IdUserThird, (i - 1), posicion);
                publi.generarPostUser();
                PanelPosts.Controls.Add(publi.post);
                posicion = aux * i;
            }
        }

        private void showUserLastConnect()
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_LastConnectedShow", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUserThird;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                LBLLastDay.Text = dt.Rows[0]["Lastconnecteddate"].ToString();
                LBLLastTime.Text = dt.Rows[0]["Lastconnectedtime"].ToString();
            }
            else
            {
                MessageBox.Show("Datos No Encontrados");

            }
        }

        private void ProfileThird_Load(object sender, EventArgs e)
        {

        }

        private void BTNAddFriend_Click(object sender, EventArgs e)
        {
            try
            {
                AddFriend();
            }
            catch (Exception E) 
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void AddFriend() 
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_AddFriendId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@SourceId", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@DestinyId", SqlDbType.Int);

            da.SelectCommand.Parameters["@SourceId"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@DestinyId"].Value = Global.IdUserThird;

            da.Fill(dt);
        }

        private void tmconected_Tick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CheckConection", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;

            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUserThird;


            da.Fill(dt);
            if(int.Parse(da.SelectCommand.Parameters["@Status"].Value.ToString()) == 0)
            {
                lblConection.Text = "Desconectado";
                showUserLastConnect();
            }
            else
            {
                lblConection.Text = "Conectado";
                LBLLastDay.Text = " ";
                LBLLastTime.Text = " ";
            }
        }
    }
}
