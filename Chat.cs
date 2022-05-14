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
    public partial class Chat : Form
    {
        
        public Chat()
        {
            InitializeComponent();
            populateFriends();
        }
        private void populateFriends()
        {
            flpFriends.Controls.Clear();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_GetFriendsList", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dt = new DataSet();
            try
            {
                da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);

                da.SelectCommand.Parameters["@Id"].Value = Global.IdUser;

                da.Fill(dt);
                if (dt.Tables[0].Rows.Count >= 1)
                {
                    lblNoFriends.Hide();
                    UserFriendsChat[] listFriends = new UserFriendsChat[dt.Tables[0].Rows.Count];

                    for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                    {
                        listFriends[i] = new UserFriendsChat(this);
                        listFriends[i].Nombre += dt.Tables[0].Rows[i]["UserName"].ToString();
                        listFriends[i].User += dt.Tables[0].Rows[i]["IdUser"].ToString();
                        
                        Byte[] myByte = new byte[0];
                        myByte = (Byte[])(dt.Tables[0].Rows[i]["ProfilePhoto"]);
                        MemoryStream ms = new MemoryStream(myByte);
                        Image imagen = Image.FromStream(ms);
                        listFriends[i].ProfilePicture = imagen;

                        flpFriends.Controls.Add(listFriends[i]);
                    }
                }
                else
                {
                    flpFriends.Controls.Clear();
                    lblNoFriends.Text = "No hay conversaciones disponibles";
                    flpFriends.Hide();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flpFriends_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
