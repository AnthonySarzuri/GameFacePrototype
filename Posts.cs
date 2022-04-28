﻿using System;
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

        //variables para Crear el post
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
        private PictureBox profilePictureComment = new PictureBox();
        private Label nameComments = new Label();
        private Label comments = new Label();
        private PictureBox profilePictureCommentWrite = new PictureBox();
        private TextBox WriteComment = new TextBox();
        private Button btnWriteComment = new Button();
        private Button btnDeleteComment = new Button();
        public Panel post = new Panel();
        private Panel commentPanel = new Panel();
        private int position;
        private int idUserFriend;
        private int RowPost;
        private int idPost;
        private int idUser;

        public Posts() { }

        public Posts(int idUser,int RowPost, int posicion)
        {
            this.idUser = idUser;
            this.RowPost = RowPost;
            this.position = posicion;

        }

        public Panel generarPostUser()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowPostUserProfile", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@idUser"].Value = idUser;


            da.Fill(dt);
            idPost = int.Parse(dt.Rows[RowPost][0].ToString());
            idUserFriend= int.Parse(dt.Rows[RowPost][1].ToString());

            try
            {
                //UserName

                name.Text = dt.Rows[RowPost][2].ToString();
                name.Location = new Point(100, 10);
               

                //CreationDate

                creationDate.Text = dt.Rows[RowPost][3].ToString();
                creationDate.Location = new Point(200, 10);

                //Description

                description.Text = dt.Rows[RowPost][4].ToString();
                description.Location = new Point(20, 100);
                description.Size = new Size(550, 100);
                description.BorderStyle = BorderStyle.FixedSingle;

                //pictureBoxProfile
                try
                {
                    byte[] mybyte = new byte[0];
                    mybyte = (byte[])dt.Rows[RowPost][5];
                    MemoryStream ms = new MemoryStream(mybyte);
                    profilePicture.Image = Image.FromStream(ms);
                }
                catch
                {

                }
                profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePicture.Location = new Point(10, 10);
                profilePicture.Size = new Size(70, 62);
                profilePicture.BorderStyle = BorderStyle.FixedSingle;
               

                //pictureBoxImagen

                try
                {
                    byte[] mybyte = new byte[0];
                    mybyte = (byte[])dt.Rows[RowPost][6];
                    MemoryStream ms = new MemoryStream(mybyte);
                    picture.Image = Image.FromStream(ms);
                    picture.Size = new Size(500, 350);
                }
                catch
                {
                    picture.Size = new Size(0, 0);
                }

                picture.BorderStyle = BorderStyle.FixedSingle;
                picture.Location = new Point(50, 220);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                //Megusta boton
                like.Click += Like_Click;
                like.Text = "Like";
                like.Location = new Point(80, 600);
                like.Size = new Size(75, 45);

                //Megusta label
                //likes.Text = da.SelectCommand.Parameters["@like"].Value.ToString();
                likes.Location = new Point(60, 615);

                //NoMegusta boton
                dislike.Click += Dislike_Click;
                dislike.Text = "Dislike";
                dislike.Location = new Point(180, 600);
                dislike.Size = new Size(75, 45);

                //NoMegusta label

                //dislikes.Text = da.SelectCommand.Parameters["@dislike"].Value.ToString();
                dislikes.Location = new Point(160, 615);

                //Comentarios boton
                btnComment.Click += BtnComment_Click;
                btnComment.Text = "Comentarios";
                btnComment.Location = new Point(280, 600);
                btnComment.Size = new Size(75, 45);

                //Comentarios label

                lblComments.Location = new Point(260, 615);

                //Share boton
                share.Click += Share_Click;
                share.Text = "Share";
                share.Location = new Point(380, 600);
                share.Size = new Size(75, 45);

                //Share label
                shares.Location = new Point(360, 615);


                //Post Entero
                //post.Size = new Size(600, 900);
                post.AutoSize = true;
                post.Margin = new Padding(50);
                post.Location = new Point(100, position);
                post.Visible = true;
                post.BorderStyle = BorderStyle.FixedSingle;
                post.Controls.Add(name);
                post.Controls.Add(creationDate);
                post.Controls.Add(picture);
                post.Controls.Add(description);
                post.Controls.Add(profilePicture);
                post.Controls.Add(like);
                post.Controls.Add(likes);
                post.Controls.Add(dislike);
                post.Controls.Add(dislikes);
                post.Controls.Add(btnComment);
                post.Controls.Add(lblComments);
                post.Controls.Add(share);
                post.Controls.Add(shares);
                post.Controls.Add(getComment());
                RefreshPost();
                return post;
            }
            catch
            {
                MessageBox.Show("no hay este post");
            }
            return post;
        }

      
        public Panel generarPostFriend()
        {


            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowPostUserFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@idUser"].Value = idUser;

            

            da.Fill(dt);
            idPost = int.Parse(dt.Rows[RowPost][0].ToString());
            idUserFriend = int.Parse(dt.Rows[RowPost][1].ToString());

            try
            {
                //UserName
              
                name.Text = dt.Rows[RowPost][2].ToString();
                name.Location = new Point(100, 10); 
                name.Click += Name_Click;

                //CreationDate

                creationDate.Text = dt.Rows[RowPost][3].ToString();
                creationDate.Location = new Point(200, 10);

                //Description
              
                description.Text = dt.Rows[RowPost][4].ToString();
                description.Location = new Point(20, 100);
                description.Size = new Size(550, 100);
                description.BorderStyle = BorderStyle.FixedSingle;

                //pictureBoxProfile
                try
                {
                    byte[] mybyte = new byte[0];
                    mybyte = (byte[])dt.Rows[RowPost][5];
                    MemoryStream ms = new MemoryStream(mybyte);
                    profilePicture.Image = Image.FromStream(ms);
                }
                catch
                {

                }
                profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePicture.Location = new Point(10, 10);
                profilePicture.Size = new Size(70, 62);
                profilePicture.BorderStyle = BorderStyle.FixedSingle;

                //pictureBoxImagen

                try
                {
                    byte[] mybyte = new byte[0];
                    mybyte = (byte[])dt.Rows[RowPost][6];
                    MemoryStream ms = new MemoryStream(mybyte);
                    picture.Image = Image.FromStream(ms);
                    picture.Size = new Size(500, 350);
                }
                catch
                {
                    picture.Size = new Size(0, 0);
                }

                picture.BorderStyle = BorderStyle.FixedSingle;
                picture.Location = new Point(50, 220);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                //Megusta boton
                like.Click += Like_Click;
                like.Text = "Like";
                like.Location = new Point(80, 600);
                like.Size = new Size(75, 45);

                //Megusta label
                //likes.Text = da.SelectCommand.Parameters["@like"].Value.ToString();
                likes.Location = new Point(60, 615);

                //NoMegusta boton
                dislike.Click += Dislike_Click;
                dislike.Text = "Dislike";
                dislike.Location = new Point(180, 600);
                dislike.Size = new Size(75, 45);

                //NoMegusta label

                //dislikes.Text = da.SelectCommand.Parameters["@dislike"].Value.ToString();
                dislikes.Location = new Point(160, 615);

                //Comentarios boton
                btnComment.Click += BtnComment_Click;
                btnComment.Text = "Comentarios";
                btnComment.Location = new Point(280, 600);
                btnComment.Size = new Size(75, 45);

                //Comentarios label

                lblComments.Location = new Point(260, 615);

                //Share boton
                share.Click += Share_Click;
                share.Text = "Share";
                share.Location = new Point(380, 600);
                share.Size = new Size(75, 45);

                //Share label
                shares.Location = new Point(360, 615);


                //Post Entero
                //post.Size = new Size(600, 900);
                post.AutoSize = true;
                post.Margin = new Padding(50);
                post.Location = new Point(100, position);
                post.Visible = true;
                post.BorderStyle = BorderStyle.FixedSingle;
                post.Controls.Add(name);
                post.Controls.Add(creationDate);
                post.Controls.Add(picture);
                post.Controls.Add(description);
                post.Controls.Add(profilePicture);
                post.Controls.Add(like);
                post.Controls.Add(likes);
                post.Controls.Add(dislike);
                post.Controls.Add(dislikes);
                post.Controls.Add(btnComment);
                post.Controls.Add(lblComments);
                post.Controls.Add(share);
                post.Controls.Add(shares);
                post.Controls.Add(getComment());
                RefreshPost();
                return post;
            }
            catch
            {
                MessageBox.Show("no hay este post");
            }
            return post;
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Global.IdUserThird= idUserFriend;
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
            if (condicionShare=="True")
            {
                removeShare();
            }
            else
            {
                addShare();
            }       
            RefreshPost();
        }


        public void RefreshPost()
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
                mybyte = (byte[])dt.Rows[0][4];
                MemoryStream ms = new MemoryStream(mybyte);
                picture.Image = Image.FromStream(ms);
            }
            catch
            {
                
            }

        }
        private void Validarreaccion()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_ValidateReaction", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idusuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@mensaje", SqlDbType.Int).Direction = ParameterDirection.Output;


            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idusuario"].Value = Global.IdUser;

            da.Fill(dt);
            if (int.Parse(da.SelectCommand.Parameters["@mensaje"].Value.ToString())==1) 
            {
                condicion = dt.Rows[0][0].ToString();
                idReaccion = dt.Rows[0][1].ToString();
            }
               
                
           
        }

        private void ValidarShare()
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
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
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);

            SqlDataAdapter da = new SqlDataAdapter("SP_RemoveShare", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@idPost"].Value = idPost;
            da.SelectCommand.Parameters["@idUsuario"].Value = Global.IdUser;
            da.Fill(dt);
        }

        //comments
        private Panel getComment()
        {
            //Profile PictureComentarios
            profilePictureComment.BorderStyle = BorderStyle.FixedSingle;
            profilePictureComment.Size = new Size(50, 32);
            profilePictureComment.Location = new Point(10, 10);

            //nombre usuario comentario
            nameComments.Text = "Juanito Perez";
            nameComments.Location = new Point(100, 10);

            //Comentario
            comments.Text = "Viva Superman";
            comments.Location = new Point(100, 40);
            comments.Size = new Size(300, 20);

            //Foto de perfil escribir comentario
            profilePictureCommentWrite.BorderStyle = BorderStyle.FixedSingle;
            profilePictureCommentWrite.Size = new Size(50, 32);
            profilePictureCommentWrite.Location = new Point(10, 150);

            //Ecribir Comentario
            WriteComment.Text = "Escriba su comentario";
            WriteComment.BorderStyle = BorderStyle.FixedSingle;
            WriteComment.Location = new Point(70, 160);
            WriteComment.Size = new Size(300, 30);


            //boton comentar
            btnComment.Click += BtnComment_Click1;
            btnWriteComment.Text = "Send";
            btnWriteComment.Location = new Point(370, 170);
            btnWriteComment.Size = new Size(50, 20);

            //boton eliminar comentario
            btnDeleteComment.Click += BtnDeleteComment_Click;
            btnDeleteComment.Text = "del";
            btnDeleteComment.Location = new Point(370, 150);
            btnDeleteComment.Size = new Size(50, 20);

            //Panel de Comentarios
            commentPanel.Visible = false;
            commentPanel.Size = new Size(500, 200);
            commentPanel.Location = new Point(50, 650);
            commentPanel.BorderStyle = BorderStyle.FixedSingle;
            commentPanel.Controls.Add(profilePictureComment);
            commentPanel.Controls.Add(nameComments);
            commentPanel.Controls.Add(comments);
            commentPanel.Controls.Add(profilePictureCommentWrite);
            commentPanel.Controls.Add(WriteComment);
            commentPanel.Controls.Add(btnWriteComment);
            commentPanel.Controls.Add(btnDeleteComment);
            return commentPanel;
        }
        private void ShowComent()
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowComment", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);

            da.SelectCommand.Parameters["@Id"].Value = 5;

            da.Fill(dt);
            nameComments.Text = dt.Rows[0][1].ToString();
            comments.Text = dt.Rows[0][2].ToString();

        }
        private void BtnDeleteComment_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_DeleteComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPost", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = 1;
            da.SelectCommand.Parameters["@IdPost"].Value = 1;
            da.SelectCommand.Parameters["@Id"].Value = 1;

            da.Fill(dt);
            ShowComent();
        }

        private void BtnComment_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CreateComments", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@commentary", SqlDbType.NVarChar, 250);
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idPost", SqlDbType.Int);

            da.SelectCommand.Parameters["@commentary"].Value = WriteComment.Text;
            da.SelectCommand.Parameters["@idUser"].Value = 1;
            da.SelectCommand.Parameters["@idPost"].Value = 1;

            da.Fill(dt);
            ShowComent();
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            if (commentPanel.Visible == true)
            {
                commentPanel.Visible = false;
            }
            else if (commentPanel.Visible == false)
            {
                commentPanel.Visible = true;
            }
            ShowComent();

        }

    }
}
