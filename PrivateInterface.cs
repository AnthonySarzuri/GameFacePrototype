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
    public partial class PrivateInterface : Form
    {
        private int postCount;
        private int continuar;
        private int pos;
        public PrivateInterface()
        {
            
            InitializeComponent();
            generarPost();
            lastConnected();
            
        }
        private void generarPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;

            da.Fill(dt);


            int posicion = 0;
            int aux = 1100;
            int count = int.Parse(dt.Rows[0][0].ToString());
            postCount = int.Parse(dt.Rows[0][0].ToString());
            for (int i = 1; i <= count; i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1), posicion);
                publi.generarPostFriend();
                mainPanel.Controls.Add(publi.post);
                posicion = aux * i;
                pos = posicion;
                continuar = i + 1;
                if (i == 10)
                {
                    break;
                }

            }
        }
        private void newPost()
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;

            da.Fill(dt);

            int posicion = pos;
            int aux = 1100;
            int count = int.Parse(dt.Rows[0][0].ToString());
            postCount = int.Parse(dt.Rows[0][0].ToString());
            for (int i = continuar; i <= count; i++)
            {
                Posts publi = new Posts(Global.IdUser, (i - 1), posicion);
                publi.generarPostFriend();
                mainPanel.Controls.Add(publi.post);
                posicion = aux * i;
                pos = posicion;
                continuar = i + 1;
                if (i % 10 == 0)
                {

                    break;
                }
            }
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            conectedDOWN();
            Application.Exit();
        }
        private void lastConnected()
        {
            this.FormClosing += CreatePostTest_FormClosing;
        }

        private void CreatePostTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_LastConnected", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUser;

            da.Fill(dt);
        }

        private void bntProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
            profile.FormClosing += Profile_FormClosing;
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrivateInterface_Load(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (tbSearch.Text == "")
            {
                btnLimpiar.Enabled = false;
                btnBuscar.Enabled = false;
            }
            else
            {
                btnLimpiar.Enabled = true;
                btnBuscar.Enabled = true;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            lblNotFound.Text = "";
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_SearchPeople", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dt = new DataSet();
            try
            {
                da.SelectCommand.Parameters.Add("@ParamSearch", SqlDbType.NVarChar, 50);

                da.SelectCommand.Parameters["@ParamSearch"].Value = tbSearch.Text;

                da.Fill(dt);
                if (dt.Tables[0].Rows.Count >= 1)
                {
                    AddFriends[] listFriends = new AddFriends[dt.Tables[0].Rows.Count];

                    for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                    {
                        listFriends[i] = new AddFriends();
                        listFriends[i].nombre += dt.Tables[0].Rows[i]["UserName"].ToString();
                        listFriends[i].username += dt.Tables[0].Rows[i]["IdUser"].ToString();


                        Byte[] myByte = new byte[0];
                        myByte = (Byte[])(dt.Tables[0].Rows[i]["ProfilePhoto"]);
                        MemoryStream ms = new MemoryStream(myByte);
                        Image imagen = Image.FromStream(ms);
                        listFriends[i].profilepicture = imagen;

                        flowLayoutPanel1.Controls.Add(listFriends[i]);
                    }
                }
                else
                {
                    lblNotFound.Text = "No se encontró a ningún usuario con ese nombre o id";
                    tbSearch.Text = "";
                    flowLayoutPanel1.Controls.Clear();
                }


            }
            catch (Exception E)
            {
                MessageBox.Show("Ha ocurrido un error", "Lo Sentimos :(");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            generarPost();
        }

        private void conectedDOWN()
        {
            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ConectedDOWN", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUser", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUser"].Value = Global.IdUser;

            da.Fill(dt);
            Global.Status = 0;
        }

        private void btnRefreshNewPost_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            generarPost();
            btnRefreshNewPost.Visible = false;
        }

        private void tmrefreshNewPosts_Tick(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string sConexion = Global.Conexion;
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CountPostFriends", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUser", SqlDbType.Int);
            da.SelectCommand.Parameters["@idUser"].Value = Global.IdUser;

            da.Fill(dt);

            if (postCount < int.Parse(dt.Rows[0][0].ToString()))
            {
                postCount = int.Parse(dt.Rows[0][0].ToString());
                btnRefreshNewPost.Visible = true;
            }
        }

        private void btnNewPosts_Click(object sender, EventArgs e)
        {
            newPost();
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
