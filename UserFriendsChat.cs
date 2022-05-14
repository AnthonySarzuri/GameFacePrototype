using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    public partial class UserFriendsChat : UserControl
    {
        Form formulario;
        public UserFriendsChat()
        {
            InitializeComponent();
        }
        public UserFriendsChat(Form formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
            
        }
        private string _name;
        private string _user;
        private Image _profilePic;
        
       
        public string Nombre
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; lblUser.Text = value; }
        }

        public Image ProfilePicture
        {
            get { return _profilePic; }
            set { _profilePic = value; pbProfilePic.Image = value; }
        }
        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void UserFriendsChat_Load(object sender, EventArgs e)
        {

        }

        private void btndelFriend_Click(object sender, EventArgs e)
        {
            Conversation chats = new Conversation();
            chats.Show();
           
        }

       
    }
}
