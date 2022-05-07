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
    public partial class UCFriends : UserControl
    {
        public UCFriends()
        {
            InitializeComponent();
        }

        private string _name;
        private string _user;
        private Image _profilePic;

        public string Nombre
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; lblUser.Text = value; }
        }

        public Image ProfilePicture
        {
            get { return _profilePic; }
            set { _profilePic = value; pbProfilePic.Image = value; }
        }

        private void btndelFriend_Click(object sender, EventArgs e)
        {
            try
            {
                string sConexion = Global.Conexion;

                SqlConnection dataConnection = new SqlConnection(sConexion);

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SP_RejectFriend", dataConnection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dt = new DataSet();

                    da.SelectCommand.Parameters.Add("@SourceId", SqlDbType.Int);
                    da.SelectCommand.Parameters.Add("@DestinyId", SqlDbType.NVarChar, 50);

                    da.SelectCommand.Parameters["@SourceId"].Value = Global.IdUser;
                    da.SelectCommand.Parameters["@DestinyId"].Value = lblUser.Text;

                    da.Fill(dt);
                }
                catch
                {
                        MessageBox.Show("Hubo un error");
                }
                
                btndelFriend.Hide();
                lblState.Text = "Amistad eliminada";

            }
            catch (Exception E)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
