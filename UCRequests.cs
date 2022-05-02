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
    public partial class UCRequests : UserControl
    {
        public UCRequests()
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

        private void btnaccFriend_Click(object sender, EventArgs e)
        {
            try
            {
                string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

                SqlConnection dataConnection = new SqlConnection(sConexion);

                SqlDataAdapter dapt = new SqlDataAdapter("SP_GetIdUserById", dataConnection);
                dapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dtst = new DataSet();
                dapt.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);
                dapt.SelectCommand.Parameters["@Id"].Value = (int)Global.IdUser;
                dapt.Fill(dtst);
                string usid = dtst.Tables[0].Rows[0]["IdUser"].ToString();

                SqlDataAdapter daptr = new SqlDataAdapter("SP_GetIdByIdUser", dataConnection);
                daptr.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dtset = new DataSet();
                daptr.SelectCommand.Parameters.Add("@IdUser", SqlDbType.NVarChar, 50);
                daptr.SelectCommand.Parameters["@IdUser"].Value = lblUser.Text;
                daptr.Fill(dtset);

                int usidthird = (int)dtset.Tables[0].Rows[0]["Id"];

                SqlDataAdapter da = new SqlDataAdapter("SP_AcceptFriend", dataConnection);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dt = new DataSet();

                da.SelectCommand.Parameters.Add("@SourceId", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@DestinyId", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@SourceId"].Value = usidthird;
                da.SelectCommand.Parameters["@DestinyId"].Value = usid;

                da.Fill(dt);

                lblState.Text = "Solicitud aceptada";
                btnaccFriend.Hide();
                btndelFReq.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error");
            }
        }

        private void btndelFReq_Click(object sender, EventArgs e)
        {
            try
            {
                string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

                SqlConnection dataConnection = new SqlConnection(sConexion);

                SqlDataAdapter dapt = new SqlDataAdapter("SP_GetIdUserById", dataConnection);
                dapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dtst = new DataSet();
                dapt.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);
                dapt.SelectCommand.Parameters["@Id"].Value = (int)Global.IdUser;
                dapt.Fill(dtst);
                string usid = dtst.Tables[0].Rows[0]["IdUser"].ToString();

                SqlDataAdapter daptr = new SqlDataAdapter("SP_GetIdByIdUser", dataConnection);
                daptr.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dtset = new DataSet();
                daptr.SelectCommand.Parameters.Add("@IdUser", SqlDbType.NVarChar, 50);
                daptr.SelectCommand.Parameters["@IdUser"].Value = lblUser.Text;
                daptr.Fill(dtset);

                int usidthird = (int)dtset.Tables[0].Rows[0]["Id"];


                SqlDataAdapter da = new SqlDataAdapter("SP_RejectFriend", dataConnection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dt = new DataSet();

                da.SelectCommand.Parameters.Add("@SourceId", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@DestinyId", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@SourceId"].Value = usidthird;
                da.SelectCommand.Parameters["@DestinyId"].Value = usid;

                da.Fill(dt);

                lblState.Text = "Solicitud rechazada";
                btnaccFriend.Hide();
                btndelFReq.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
