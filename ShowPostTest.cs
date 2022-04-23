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
    public partial class ShowPostTest : Form
    {
      
        

        public ShowPostTest()
        {
            InitializeComponent();
            //ShowPost();
            //panel2.Hide();
        }
        //Generar Posts
        private void generarPost()
        {
            Posts publi = new Posts();
            PanelPrincipal.Controls.Add(publi.generarPost());
           
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            generarPost();
        }

        private void btnComentarioPrueba_Click(object sender, EventArgs e)
        {
            CommentsTest commentsTest = new CommentsTest();
            commentsTest.Show();
            this.Hide();
        }



        //post de muestra


        //private void ShowPost()
        //{
        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);
        //    SqlDataAdapter da = new SqlDataAdapter("SP_ShowPost", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;


        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

        //    da.SelectCommand.Parameters["@idPost"].Value = 1;


        //    da.Fill(dt);
        //    label1.Text = dt.Rows[0][0].ToString();
        //    label2.Text = dt.Rows[0][1].ToString();
        //    label3.Text = dt.Rows[0][2].ToString();
        //    label4.Text = dt.Rows[0][4].ToString();
        //    label5.Text = dt.Rows[0][5].ToString();
        //    label6.Text = dt.Rows[0][6].ToString();
        //    label7.Text = dt.Rows[0][7].ToString();

        //    try
        //    {
        //        Byte[] mybyte = new Byte[0];
        //        mybyte = (Byte[])(dt.Rows[0][3]);
        //        MemoryStream ms = new MemoryStream(mybyte);
        //        pictureBox2.Image = Image.FromStream(ms);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se encuentra esa imagen");
        //    }

        //}

        //private void btnLike_Click(object sender, EventArgs e)
        //{

        //    Validarreaccion();

        //    if (mensaje == "1")
        //    {
        //        addLike();
        //    }
        //    else if (condicion == "False")
        //    {
        //        addLike();
        //    }
        //    else if (condicion == "True" && idReaccion != "1")
        //    {

        //        addLike();
        //    }
        //    else if (condicion == "True" && idReaccion == "1")
        //    {
        //        removeLike();
        //    }
        //}

        //private void btnDislike_Click(object sender, EventArgs e)
        //{


        //    Validarreaccion();

        //    if (mensaje == "1")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "False")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "True" && idReaccion != "2")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "True" && idReaccion == "2")
        //    {
        //        removeDislike();
        //    }

        //}
        //private void Validarreaccion()
        //{

        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);

        //    SqlDataAdapter da = new SqlDataAdapter("SP_ShowReactionCondition", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@idusuario", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@mensaje", SqlDbType.VarChar, 1).Direction = ParameterDirection.Output;


        //    da.SelectCommand.Parameters["@idPost"].Value = 1;
        //    da.SelectCommand.Parameters["@idusuario"].Value = 6;

        //    da.Fill(dt);
        //    if (da.SelectCommand.Parameters["@mensaje"].Value.ToString() == "0")
        //    {
        //        mensaje = da.SelectCommand.Parameters["@mensaje"].Value.ToString();
        //        condicion = dt.Rows[0][0].ToString();
        //        idReaccion = dt.Rows[0][1].ToString();
        //    }
        //    else
        //    {
        //        mensaje = da.SelectCommand.Parameters["@mensaje"].Value.ToString();
        //    }


        //}

        //private void addLike()
        //{
        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);

        //    SqlDataAdapter da = new SqlDataAdapter("SP_Addlikes", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

        //    da.SelectCommand.Parameters["@idPost"].Value = 1;
        //    da.SelectCommand.Parameters["@idUsuario"].Value = 6;
        //    da.Fill(dt);

        //    ShowPost();

        //}
        //private void removeLike()
        //{
        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);
        //    SqlDataAdapter da = new SqlDataAdapter("SP_RemoveLikes", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

        //    da.SelectCommand.Parameters["@idPost"].Value = 1;
        //    da.SelectCommand.Parameters["@idUsuario"].Value = 6;
        //    da.Fill(dt);

        //    ShowPost();
        //}
        //private void addDislike()
        //{
        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);

        //    SqlDataAdapter da = new SqlDataAdapter("SP_AddDislikes", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

        //    da.SelectCommand.Parameters["@idPost"].Value = 1;
        //    da.SelectCommand.Parameters["@idUsuario"].Value = 6;
        //    da.Fill(dt);

        //    ShowPost();

        //}
        //private void removeDislike()
        //{
        //    DataTable dt = new DataTable();
        //    string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
        //    SqlConnection dataConnection = new SqlConnection(sConexion);

        //    SqlDataAdapter da = new SqlDataAdapter("SP_RemoveDislikes", dataConnection);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
        //    da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

        //    da.SelectCommand.Parameters["@idPost"].Value = 1;
        //    da.SelectCommand.Parameters["@idUsuario"].Value = 6;
        //    da.Fill(dt);

        //   ShowPost();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Validarreaccion();

        //    if (mensaje == "1")
        //    {
        //        addLike();
        //    }
        //    else if (condicion == "False")
        //    {
        //        addLike();
        //    }
        //    else if (condicion == "True" && idReaccion != "1")
        //    {

        //        addLike();
        //    }
        //    else if (condicion == "True" && idReaccion == "1")
        //    {
        //        removeLike();
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Validarreaccion();

        //    if (mensaje == "1")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "False")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "True" && idReaccion != "2")
        //    {
        //        addDislike();
        //    }
        //    else if (condicion == "True" && idReaccion == "2")
        //    {
        //        removeDislike();
        //    }


        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    panel2.Show();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}
    }
}
