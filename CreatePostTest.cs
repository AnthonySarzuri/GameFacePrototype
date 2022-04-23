﻿using System;
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
    public partial class CreatePostTest : Form
    {
        public CreatePostTest()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
               pictureBox1.Image = new Bitmap(op.FileName);
            }
        }


        private void btnCreatePost_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CreatePost", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250);
            da.SelectCommand.Parameters.Add("@picture", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);


            da.SelectCommand.Parameters["@Description"].Value = tbdescripcion.Text;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@picture"].Value = ms.GetBuffer();
            da.SelectCommand.Parameters["@idUsuario"].Value = 5;

            da.Fill(dt);
        }

        private void btMostrar_Click_1(object sender, EventArgs e)
        {
            ShowPostTest form1 = new ShowPostTest();
            form1.Show();
            this.Hide();

        }
    }
}
