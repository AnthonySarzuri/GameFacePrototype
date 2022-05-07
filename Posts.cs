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
using System.ComponentModel;

namespace GameFacePrototype
{
    internal class Posts
    {

        //variables para validar
        private string condicionShare;
        private string condicion;
        private string idReaccion;

        //variables para generar un post
        private int position;
        private int idUserFriend;
        private int RowPost;
        private int idPost;
        private int idUser;

        //Atributos para Crear el post
        private Label name = new Label();
        private Label creationDate = new Label();
        private Label description = new Label();
        private PictureBox profilePicture = new PictureBox();
        private PictureBox picture = new PictureBox();
        private Button like = new Button();
        private Label likes = new Label();
        private Button dislike = new Button();
        private Label dislikes = new Label();
        private Button btnComment = new Button();
        private Label lblComments = new Label();
        private Button share = new Button();
        private Label shares = new Label();
        private Panel reactionPanel = new Panel();
        public Panel post = new Panel();

        //Atributos para los comentarios
        //Atributo el panel de los comentarios
        private Panel commentPanel = new Panel();

        //Atributos para escribir comentario y borrar comentario
        private PictureBox profilePictureCommentWrite = new PictureBox();
        private TextBox WriteComment = new TextBox();
        private Button btnWriteComment = new Button();

        private Panel panelWriteComment = new Panel();

        //Atributo el panel total de comentarios
        public Panel PanelComment = new Panel();
        public Posts() { }

        public Posts(int idUser, int RowPost, int posicion)
        {
            this.idUser = idUser;
            this.RowPost = RowPost;
            this.position = posicion;

        }

        public Panel generarPostUser()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowPostUserProfile", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@idUser"].Value = idUser;


            da.Fill(dt);
            idPost = int.Parse(dt.Rows[RowPost][0].ToString());
            idUserFriend = int.Parse(dt.Rows[RowPost][1].ToString());


            //UserName
            name.Location = new Point(100, 10);


            //CreationDate
            creationDate.Location = new Point(200, 10);

            //Description


            description.Location = new Point(20, 100);
            description.Size = new Size(550, 100);
            description.BorderStyle = BorderStyle.FixedSingle;

            //pictureBoxProfile

            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.Location = new Point(10, 10);
            profilePicture.Size = new Size(70, 62);
            profilePicture.BorderStyle = BorderStyle.FixedSingle;


            //pictureBoxImagen
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Location = new Point(40, 220);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            string a = dt.Rows[RowPost][6].ToString();
            if (dt.Rows[RowPost][6].ToString() != "")
            {

                picture.Size = new Size(500, 350);
                PanelComment.Location = new Point(40, 700);
                reactionPanel.Location = new Point(40, 600);
            }
            else
            {
                picture.Size = new Size(0, 0);
                PanelComment.Location = new Point(40, 320);
                reactionPanel.Location = new Point(40, 220);
            }


            //Panel de Botones de reacciones comentarios y shares
            reactionPanel.Size = new Size(500, 100);
            reactionPanel.BorderStyle = BorderStyle.FixedSingle;

            //Panel de comentarios principal
            PanelComment.Visible = false;
            PanelComment.Size = new Size(500, 350);
            PanelComment.BorderStyle = BorderStyle.FixedSingle;

            //Megusta boton
            like.Click += Like_Click;
            like.Cursor = Cursors.Hand;
            like.Text = "Like";
            like.Location = new Point(60, 40);
            like.Size = new Size(75, 45);

            //Megusta label

            likes.Location = new Point(40, 45);

            //NoMegusta boton
            dislike.Click += Dislike_Click;
            dislike.Cursor = Cursors.Hand;
            dislike.Text = "Dislike";
            dislike.Location = new Point(160, 40);
            dislike.Size = new Size(75, 45);

            //NoMegusta label                
            dislikes.Location = new Point(140, 45);

            //Comentarios boton
            btnComment.Click += BtnComment_Click;
            btnComment.Cursor = Cursors.Hand;
            btnComment.Text = "Comentarios";
            btnComment.Location = new Point(260, 40);
            btnComment.Size = new Size(75, 45);

            //Comentarios label

            lblComments.Location = new Point(240, 45);

            //Share boton
            share.Click += Share_Click;
            share.Cursor = Cursors.Hand;
            share.Text = "Share";
            share.Location = new Point(360, 40);
            share.Size = new Size(75, 45);

            //Share label
            shares.Location = new Point(340, 45);

            //insertar al panel de reacciones
            reactionPanel.Controls.Add(like);
            reactionPanel.Controls.Add(likes);
            reactionPanel.Controls.Add(dislike);
            reactionPanel.Controls.Add(dislikes);
            reactionPanel.Controls.Add(btnComment);
            reactionPanel.Controls.Add(lblComments);
            reactionPanel.Controls.Add(share);
            reactionPanel.Controls.Add(shares);

            //boton comentar
            btnWriteComment.Click += BtnComment_Click1;
            btnWriteComment.Text = "Send";
            btnWriteComment.Location = new Point(370, 40);
            btnWriteComment.Size = new Size(50, 40);

            //Foto de perfil escribir comentario
            profilePictureCommentWrite.BorderStyle = BorderStyle.FixedSingle;
            profilePictureCommentWrite.Size = new Size(50, 32);
            profilePictureCommentWrite.Location = new Point(10, 40);
            profilePictureCommentWrite.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureComment();

            //Ecribir Comentario
            WriteComment.BorderStyle = BorderStyle.FixedSingle;
            WriteComment.Location = new Point(70, 40);
            WriteComment.Size = new Size(300, 30);


            //Panel para escribir comentario
            //Panel de Comentarios
            panelWriteComment.Dock = DockStyle.Bottom;
            panelWriteComment.MaximumSize = new Size(500, 90);
            panelWriteComment.Controls.Add(btnWriteComment);
            panelWriteComment.Controls.Add(profilePictureCommentWrite);
            panelWriteComment.Controls.Add(WriteComment);

            GenerarComment();
            //insertar Coentarios
            PanelComment.Controls.Add(commentPanel);
            PanelComment.Controls.Add(panelWriteComment);



            //Post Entero
            //post.Size = new Size(600, 900);
            post.AutoSize = true;
            post.Location = new Point(100, position);
            post.Visible = true;
            post.BorderStyle = BorderStyle.FixedSingle;
            post.Controls.Add(name);
            post.Controls.Add(creationDate);
            post.Controls.Add(picture);
            post.Controls.Add(description);
            post.Controls.Add(profilePicture);
            post.Controls.Add(reactionPanel);
            post.Controls.Add(PanelComment);
            RefreshPost();
            return post;

        }

        public Panel generarPostFriend()
        {


            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowPostUserFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@idUser"].Value = idUser;



            da.Fill(dt);
            idPost = int.Parse(dt.Rows[RowPost][0].ToString());
            idUserFriend = int.Parse(dt.Rows[RowPost][1].ToString());


            //UserName

            name.Cursor = Cursors.Hand;
            name.Location = new Point(100, 10);
            name.Click += Name_Click;

            //CreationDate


            creationDate.Location = new Point(200, 10);

            //Description


            description.Location = new Point(20, 100);
            description.Size = new Size(550, 100);
            description.BorderStyle = BorderStyle.FixedSingle;

            //pictureBoxProfile

            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.Location = new Point(10, 10);
            profilePicture.Size = new Size(70, 62);
            profilePicture.BorderStyle = BorderStyle.FixedSingle;

            //pictureBoxImagen
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Location = new Point(40, 220);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            if (dt.Rows[RowPost][6].ToString() != "")
            {

                picture.Size = new Size(500, 350);
                PanelComment.Location = new Point(40, 700);
                reactionPanel.Location = new Point(40, 600);
            }
            else
            {
                picture.Size = new Size(0, 0);
                PanelComment.Location = new Point(40, 320);
                reactionPanel.Location = new Point(40, 220);
            }


            //Panel de Botones de reacciones comentarios y shares
            reactionPanel.Size = new Size(500, 100);
            reactionPanel.BorderStyle = BorderStyle.FixedSingle;

            //Panel de comentarios principal
            PanelComment.Visible = false;
            PanelComment.Size = new Size(500, 350);
            PanelComment.BorderStyle = BorderStyle.FixedSingle;

            //Megusta boton
            like.Click += Like_Click;
            like.Cursor = Cursors.Hand;
            like.Text = "Like";
            like.Location = new Point(60, 40);
            like.Size = new Size(75, 45);

            //Megusta label

            likes.Location = new Point(40, 45);

            //NoMegusta boton
            dislike.Click += Dislike_Click;
            dislike.Cursor = Cursors.Hand;
            dislike.Text = "Dislike";
            dislike.Location = new Point(160, 40);
            dislike.Size = new Size(75, 45);

            //NoMegusta label                
            dislikes.Location = new Point(140, 45);

            //Comentarios boton
            btnComment.Click += BtnComment_Click;
            btnComment.Cursor = Cursors.Hand;
            btnComment.Text = "Comentarios";
            btnComment.Location = new Point(260, 40);
            btnComment.Size = new Size(75, 45);

            //Comentarios label

            lblComments.Location = new Point(240, 45);

            //Share boton
            share.Click += Share_Click;
            share.Cursor = Cursors.Hand;
            share.Text = "Share";
            share.Location = new Point(360, 40);
            share.Size = new Size(75, 45);

            //Share label
            shares.Location = new Point(340, 45);
            //insertar al panel de reacciones
            reactionPanel.Controls.Add(like);
            reactionPanel.Controls.Add(likes);
            reactionPanel.Controls.Add(dislike);
            reactionPanel.Controls.Add(dislikes);
            reactionPanel.Controls.Add(btnComment);
            reactionPanel.Controls.Add(lblComments);
            reactionPanel.Controls.Add(share);
            reactionPanel.Controls.Add(shares);

            //boton comentar
            btnWriteComment.Click += BtnComment_Click1;
            btnWriteComment.Text = "Comentar";
            btnWriteComment.Location = new Point(370, 40);
            btnComment.AutoSize = true;
            btnWriteComment.MaximumSize = new Size(70, 40);

            //Foto de perfil escribir comentario
            profilePictureCommentWrite.BorderStyle = BorderStyle.FixedSingle;
            profilePictureCommentWrite.Size = new Size(50, 32);
            profilePictureCommentWrite.Location = new Point(10, 30);
            profilePictureCommentWrite.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureComment();

            //Ecribir Comentario
            WriteComment.BorderStyle = BorderStyle.FixedSingle;
            WriteComment.Location = new Point(70, 40);
            WriteComment.Size = new Size(300, 30);


            //Panel para escribir comentario
            //Panel de Comentarios
            panelWriteComment.Dock = DockStyle.Bottom;
            panelWriteComment.MaximumSize = new Size(500, 90);
            panelWriteComment.Controls.Add(btnWriteComment);
            panelWriteComment.Controls.Add(profilePictureCommentWrite);
            panelWriteComment.Controls.Add(WriteComment);

            GenerarComment();
            //insertar Coentarios
            PanelComment.Controls.Add(commentPanel);
            PanelComment.Controls.Add(panelWriteComment);




            //Post Entero
            //post.Size = new Size(600, 900);

            post.AutoSize = true;
            post.Location = new Point(100, position);
            post.Visible = true;
            post.BorderStyle = BorderStyle.FixedSingle;
            post.Controls.Add(name);
            post.Controls.Add(creationDate);
            post.Controls.Add(picture);
            post.Controls.Add(description);
            post.Controls.Add(profilePicture);
            post.Controls.Add(reactionPanel);
            post.Controls.Add(PanelComment);
            RefreshPost();
            return post;


        }

        //mostrar en el posts

        public void RefreshPost()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowPost", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters.Add("@like", SqlDbType.Int).Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters.Add("@dislike", SqlDbType.Int).Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters.Add("@shares", SqlDbType.Int).Direction = ParameterDirection.Output;

            da.Fill(dt);
            name.Text = dt.Rows[0][0].ToString();
            creationDate.Text = dt.Rows[0][1].ToString();
            description.Text = dt.Rows[0][2].ToString();
            likes.Text = da.SelectCommand.Parameters["@like"].Value.ToString();
            dislikes.Text = da.SelectCommand.Parameters["@dislike"].Value.ToString();
            shares.Text = da.SelectCommand.Parameters["@shares"].Value.ToString();
            try
            {
                byte[] mybyte = new byte[0];
                mybyte = (byte[])dt.Rows[0][3];
                MemoryStream ms = new MemoryStream(mybyte);
                profilePicture.Image = Image.FromStream(ms);
            }
            catch
            {

            }
            try
            {
                byte[] mybyte = new byte[0];
                mybyte = (byte[])dt.Rows[0][4];
                MemoryStream ms = new MemoryStream(mybyte);
                picture.Image = Image.FromStream(ms);
            }
            catch
            {

            }

        }
        private void profilePictureComment()
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

                Byte[] myByte = new byte[0];
                myByte = (Byte[])(dt.Rows[0]["ProfilePhoto"]);
                MemoryStream ms = new MemoryStream(myByte);
                profilePictureCommentWrite.Image = Image.FromStream(ms);
            }
            else
            {

            }
        }


        //Botones del post
        private void Validarreaccion()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_ValidateReaction", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idusuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@mensaje", SqlDbType.Int).Direction = ParameterDirection.Output;


            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idusuario"].Value = Global.IdUser;

            da.Fill(dt);
            if (int.Parse(da.SelectCommand.Parameters["@mensaje"].Value.ToString()) == 1)
            {
                condicion = dt.Rows[0][0].ToString();
                idReaccion = dt.Rows[0][1].ToString();
            }



        }

        private void ValidarShare()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_ValidateShare", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idusuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@mensaje", SqlDbType.Int).Direction = ParameterDirection.Output;

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idusuario"].Value = Global.IdUser;

            da.Fill(dt);

            if (int.Parse(da.SelectCommand.Parameters["@mensaje"].Value.ToString()) == 1)
            {
                condicionShare = dt.Rows[0][0].ToString();
            }


        }
        private void addLike()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_Addlikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);


            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);



        }
        private void removeLike()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_RemoveLikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);


        }
        private void addDislike()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_AddDislikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);
        }
        private void removeDislike()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_RemoveDislikes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);
        }
        private void addShare()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_AddShare", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);
        }
        private void removeShare()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_RemoveShare", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);
        }


        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Global.IdUserThird = idUserFriend;
            ProfileThird profileThird = new ProfileThird();
            profileThird.Show();
        }
        private void Name_Click(object sender, EventArgs e)
        {
            Global.IdUserThird = idUserFriend;
            ProfileThird profileThird = new ProfileThird();
            profileThird.Show();
        }
        private void Like_Click(object sender, EventArgs e)
        {
            condicion = "";
            idReaccion = "";

            Validarreaccion();


            if (condicion == "True" && idReaccion == "1")
            {
                removeLike();
            }
            else
            {
                addLike();
            }
            RefreshPost();
        }

        private void Dislike_Click(object sender, EventArgs e)
        {
            condicion = "";
            idReaccion = "";

            Validarreaccion();


            if (condicion == "True" && idReaccion == "2")
            {
                removeDislike();
            }
            else
            {
                addDislike();
            }
            RefreshPost();
        }

        private void Share_Click(object sender, EventArgs e)
        {
            condicionShare = "";

            ValidarShare();
            if (condicionShare == "True")
            {
                removeShare();
            }
            else
            {
                addShare();
            }
            RefreshPost();
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            if (PanelComment.Visible == true)
            {
                PanelComment.Visible = false;
            }
            else if (PanelComment.Visible == false)
            {
                PanelComment.Visible = true;
            }


        }


        //comments
        private void GenerarComment()
        {
            int idpost = idPost;

            //Generar los Comentarios
            //Panel de Comentarios
            commentPanel.Location = new Point(0, 0);
            commentPanel.Size = new Size(500, 260);
            commentPanel.AutoScroll = true;

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.Fill(dt);

            int u = int.Parse(dt.Rows[0][0].ToString());
            int posicion = 0;
            int aux = 100;

            for (int i = 1; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {
                Comments comentarios = new Comments(idPost, (i - 1), posicion);
                comentarios.generarComentarios();
                commentPanel.Controls.Add(comentarios.comment);
                posicion = aux * i;
            }

        }

        private void BtnComment_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CreateComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@commentary", SqlDbType.NVarChar, 250);
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

            da.SelectCommand.Parameters["@commentary"].Value = WriteComment.Text;
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@idPost"].Value = idPost;

            da.Fill(dt);

            WriteComment.Clear();
            WriteComment.Refresh();
            commentPanel.Controls.Clear();
            GenerarComment();
            PanelComment.Controls.Add(commentPanel);

        }

    }



}

