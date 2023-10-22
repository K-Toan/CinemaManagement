using SE1735_Group6_A2.DAL;
using SE1735_Group6_A2.DTL;
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
        private DAO _dao;
        public MainGUI()
        {
            InitializeComponent();
            _dao = new DAO();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppSettings.IsLoggedIn)
            {
                _dao.Logout();
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
