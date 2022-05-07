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
    public partial class FriendsandRequests : Form
    {
        public FriendsandRequests()
        {
            InitializeComponent();
            populateFriends();
            populateRequests();
        }

        private void populateFriends()
        {
            flpFriends.Controls.Clear();
            string sConexion = Global.Conexion;

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
                    UCFriends[] listFriends = new UCFriends[dt.Tables[0].Rows.Count];
                    
                    for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                    {
                        listFriends[i] = new UCFriends();
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
                    lblNoFriends.Text = "No hay amigos para mostrar";
                    flpFriends.Hide();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }

        private void populateRequests()
        {
            flpRequests.Controls.Clear();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_GetUsersPRequests", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dt = new DataSet();
            try
            {
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

                da.SelectCommand.Parameters["@id"].Value = Global.IdUser;

                da.Fill(dt);
                if (dt.Tables[0].Rows.Count >= 1)
                {
                    UCRequests[] listFriends = new UCRequests[dt.Tables[0].Rows.Count];

                    for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                    {
                        listFriends[i] = new UCRequests();
                        listFriends[i].Nombre += dt.Tables[0].Rows[i]["UserName"].ToString();
                        listFriends[i].User += dt.Tables[0].Rows[i]["IdUser"].ToString();


                        Byte[] myByte = new byte[0];
                        myByte = (Byte[])(dt.Tables[0].Rows[i]["ProfilePhoto"]);
                        MemoryStream ms = new MemoryStream(myByte);
                        Image imagen = Image.FromStream(ms);
                        listFriends[i].ProfilePicture = imagen;

                        flpRequests.Controls.Add(listFriends[i]);
                    }
                }
                else
                {
                    flpRequests.Controls.Clear();
                    lblNoRequests.Text = "No hay solicitudes pendientes";
                    flpRequests.Hide();
                }


            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }
    }
}
