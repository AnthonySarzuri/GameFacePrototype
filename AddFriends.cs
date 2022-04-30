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
    public partial class AddFriends : UserControl
    {
        public AddFriends()
        {
            InitializeComponent();
        }
        private string _nombre;
        private string _username;
        private Image _imageprofile;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; lblName.Text = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; lblUser.Text = value; }
        }
        public Image profilepicture
        {
            get { return _imageprofile; }
            set { _imageprofile = value; pbProfilePic.Image = value; }
        }

        private void btnSeeProfile_Click(object sender, EventArgs e)
        {
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

            try
            {
                SqlConnection dataConnection = new SqlConnection(sConexion);
                SqlDataAdapter da = new SqlDataAdapter("SP_GetIdByIdUser", dataConnection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dt = new DataSet();
                da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@IdUser"].Value = lblUser.Text;
                da.Fill(dt);
                string thusid = dt.Tables[0].Rows[0]["Id"].ToString();
                int usid = Convert.ToInt32(thusid);
                Global.IdUserThird = usid;
                ProfileThird profileThird = new ProfileThird();
                profileThird.Show();
            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }
    }
}
