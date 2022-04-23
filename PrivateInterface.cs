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
    public partial class PrivateInterface : Form
    {
        public PrivateInterface()
        {
            InitializeComponent();
            lastConnected();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            edit.Show();
            this.Hide();
        }

        private void btnMostrarPosts_Click(object sender, EventArgs e)
        {
            CreatePostTest createPostTest = new CreatePostTest();
            createPostTest.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
             
            Application.Exit();
        }
        private void lastConnected()
        {
            this.FormClosing += CreatePostTest_FormClosing;
        }

        private void CreatePostTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_LastConnected", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = 1;

            da.Fill(dt);
        }
    }
}
