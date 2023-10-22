using SE1735_Group6_A2.DAL;
using SE1735_Group6_A2.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1735_Group6_A2.GUI
{
    public partial class LoginGUI : Form
    {
        private DAO _dao;
        public LoginGUI()
        {
            InitializeComponent();
            _dao = new DAO();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            _dao.Login(usernameTextBox.Text, passwordTextBox.Text);

            if (AppSettings.IsLoggedIn)
            {
                MessageBox.Show("You are logged in as administrator!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Don't have that user!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
