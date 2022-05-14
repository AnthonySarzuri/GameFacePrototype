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

        private int continuar;
       

        public Profile()
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
        //Mostrar el usuaior
        private void showUserData()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowUserId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;
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


        //Generar Posts
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
            da.Fill(dt);


            int posicion = 0;
            int aux = 1100;
            for (int i = 1; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {

                Posts publi = new Posts(Global.IdUser, (i - 1), posicion,this);
                publi.generarPostUser();
                PanelPrincipal.Controls.Add(publi.post);
                posicion = aux * i;
                continuar = i + 1;
                if (i == 10)
                {
                    break;
                }
            }
            Global.posicionPost = 0;
        }
        private void newPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;

            da.Fill(dt);

            int posicion = 1100;
            int aux = 1100;
            int count = 1;
            for (int i = continuar; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1), posicion,this);
                publi.generarPostUser();
                PanelPrincipal.Controls.Add(publi.post);
                count++;
                posicion = aux * count;
                continuar = i + 1;
                if (i % 10 == 0)
                {
                    break;
                }
            }
            Global.posicionPost = 0;
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

        private void BTNShowFriends_Click(object sender, EventArgs e)
        {
            FriendsandRequests FriendsR = new FriendsandRequests();
            FriendsR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newPost();
           
        }

       
    }
}
