﻿using System;
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
    public partial class ProfileThird : Form
    {
        
        public ProfileThird()
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

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showUserData() 
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ShowUserId", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int);

            da.SelectCommand.Parameters["@id"].Value = Global.IdUserThird;
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
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostUser", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUserThird;
            da.Fill(dt);


            int posicion = 0;
            int aux = 900;

            for (int i = 1; i <= int.Parse(dt.Rows[0][0].ToString()); i++)
            {

                Posts publi = new Posts(Global.IdUserThird, (i - 1), posicion);
                publi.generarPostUser();
                PanelPosts.Controls.Add(publi.post);
                posicion = aux * i;
            }
        }

        private void ProfileThird_Load(object sender, EventArgs e)
        {

        }
    }
}
