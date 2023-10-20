using SE1735_Group6_A2.Repository;
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
    public partial class MainGUI : Form
    {
        private AccountRepository _accountRepository;
        public MainGUI()
        {
            InitializeComponent();
            _accountRepository = new AccountRepository();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_accountRepository.checkLogin())
            {
                _accountRepository.Logout();
                MessageBox.Show("You are logged out!");
            }
            else
            {
                LoginGUI loginForm = new LoginGUI();
                loginForm.ShowDialog();
            }
        }
    }
}
