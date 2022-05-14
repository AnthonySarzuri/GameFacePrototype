using System;
using System.Collections.Generic;
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
    internal class Comments
    {
        //Variables
        private int idPost;
        private int rowComment;
        private int position;
        //Variables de cada Comentario
        private int idPostComment;
        public int idUserComment;
        public int idComment;

        //Variables para generar Commentarios
        private PictureBox profilePictureComment = new PictureBox();
        private Label nameComments = new Label();
        private Label commentsWrite = new Label();
        private Button btnDeleteComment = new Button();
        public Panel comment = new Panel();
        public Comments() { }
        public Comments(int idPost, int rowComment, int position)
        {
            this.idPost = idPost;
            this.rowComment = rowComment;
            this.position = position;
        }

        public Panel generarComentarios()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowCommentsUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;


            da.Fill(dt);

            idComment = int.Parse(dt.Rows[rowComment][0].ToString());
            idPostComment = int.Parse(dt.Rows[rowComment][1].ToString());
            idUserComment = int.Parse(dt.Rows[rowComment][2].ToString());
            int id = idComment;
            //Profile PictureComentarios
            profilePictureComment.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureComment.BorderStyle = BorderStyle.FixedSingle;
            profilePictureComment.Size = new Size(50, 32);
            profilePictureComment.Location = new Point(10, 10);

            //nombre usuario comentario
            nameComments.Location = new Point(100, 10);
            nameComments.AutoSize = true;

            //Comentario
            commentsWrite.Location = new Point(100, 30);
            commentsWrite.AutoSize = true;
            commentsWrite.MaximumSize = new Size(370, 70);



            //boton eliminar comentario
            btnDeleteComment.Click += BtnDeleteComment_Click;
            btnDeleteComment.Text = "delete";
            btnDeleteComment.Location = new Point(400, 10);
            btnDeleteComment.AutoSize = true;
            btnDeleteComment.MaximumSize = new Size(50, 20);

            //Panel del Comentario
            //comment.Size = new Size(450, 50);
            comment.AutoSize = true;
            comment.MaximumSize = new Size(450, 90);
            comment.Location = new Point(0, position);

            //comment.BorderStyle = BorderStyle.FixedSingle;
            comment.Controls.Add(profilePictureComment);
            comment.Controls.Add(nameComments);
            comment.Controls.Add(commentsWrite);

            if (Global.IdUser == idUserComment || Global.isSuperUser)
            {
                comment.Controls.Add(btnDeleteComment);
            }

            ShowComent();
            return comment;

        }


        private void ShowComent()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowComment", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdComent", SqlDbType.Int);


            da.SelectCommand.Parameters["@IdComent"].Value = idComment;

            da.Fill(dt);
            int id = idComment;
            try
            {
                byte[] mybyte = new byte[0];
                mybyte = (byte[])dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(mybyte);
                profilePictureComment.Image = Image.FromStream(ms);
            }
            catch
            {

            }
            try
            {
                nameComments.Text = dt.Rows[0][1].ToString();
                commentsWrite.Text = dt.Rows[0][2].ToString();
            }
            catch
            {

            }

        }
        private void BtnDeleteComment_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_DeleteComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.Add("@IdComent", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdComent"].Value = idComment;


            da.Fill(dt);

        }

    }
}
