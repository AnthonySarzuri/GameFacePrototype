﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "Pepe" && tbPassword.Text == "123")
            {
                PrivateInterface privIn = new PrivateInterface();
                privIn.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Todo esta mal:(";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void lblPasswordGet_Click(object sender, EventArgs e)
        {
            EnterEmail enterEmail = new EnterEmail();   
            enterEmail.Show();
            this.Hide();
        }
    }
}