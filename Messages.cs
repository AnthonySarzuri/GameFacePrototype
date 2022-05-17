using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    internal class Messages
    {
        //Variables
       
        private int rowComment;
        private int position;
        private int idFriend;
        //Variables de cada Comentario
       
        public int idMessage;

        //Variables para generar Commentarios
        private Label commentsWrite = new Label();    
        public Panel comment = new Panel();
        public Messages() { }
        public Messages( int rowComment, int position, int idFriend)
        {
          
            this.rowComment = rowComment;
            this.position = position;
            this.idFriend = idFriend;
        }

        public Panel generarComentarios()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowMessages", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idFriend", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUser;
            da.SelectCommand.Parameters["@idFriend"].Value = idFriend;


            da.Fill(dt);
            try
            {
                idMessage = int.Parse(dt.Rows[rowComment][0].ToString());
            }
            catch
            {
                idMessage = int.Parse(dt.Rows[0][0].ToString());
            }
            
                  
            //Comentario
            commentsWrite.Location = new Point(100, 30);
            commentsWrite.AutoSize = true;
            commentsWrite.MaximumSize = new Size(370, 70);

            //Panel del Comentario
            //comment.Size = new Size(450, 50);
            comment.AutoSize = true;
            comment.MaximumSize = new Size(450, 90);
            comment.BorderStyle= BorderStyle.FixedSingle;
            try
            {
                if (Global.IdUser == int.Parse(dt.Rows[rowComment][2].ToString()))
                {
                    comment.Location = new Point(200, position);
                }
                else
                {
                    comment.Location = new Point(0, position);
                }
            }
            catch
            {
                if (Global.IdUser == int.Parse(dt.Rows[0][2].ToString()))
                {
                    comment.Location = new Point(200, position);
                }
                else
                {
                    comment.Location = new Point(0, position);
                }
            }
            
           

            //comment.BorderStyle = BorderStyle.FixedSingle;
            comment.Controls.Add(commentsWrite);


            ShowComent();
            return comment;

        }


        private void ShowComent()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_GetMessages", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idMensaje", SqlDbType.Int);


            da.SelectCommand.Parameters["@idMensaje"].Value = idMessage;

            da.Fill(dt);
            
           
            try
            {
                
                commentsWrite.Text = dt.Rows[0][1].ToString();
            }
            catch
            {

            }

        }
       
    }
}
