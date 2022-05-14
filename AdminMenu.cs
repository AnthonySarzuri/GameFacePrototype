using System;
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddReaction addReaction = new AddReaction();
            addReaction.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PrivateInterface privateInterface = new PrivateInterface();
            privateInterface.Show();
            this.Close();
        }
    }
}
