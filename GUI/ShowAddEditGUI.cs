using SE1735_Group6_A2.DAL;
using SE1735_Group6_A2.DTL;
using SE1735_Group6_A2.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE1735_Group6_A2.GUI
{
    public partial class ShowAddEditGUI : Form
    {
        private Show show = null;
        private DAO _dao = new DAO();
        private AccountRepository _accountRepository = new AccountRepository();

        public ShowAddEditGUI()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
        }

        public ShowAddEditGUI(Show show)
        {
            this.show = show;
            InitializeComponent();
            LoadDataIntoComboBox();

            // Get Data and fill into combobox
            roomComboBox.SelectedValue = show.RoomID;
            filmComboBox.SelectedValue = show.FilmID;
            dateTimePicker.Value = show.ShowDate;
            slotComboBox.SelectedValue = show.Slot;
            priceTextBox.Text = show.Price.ToString();

            // Disable combobox
            roomComboBox.Enabled = false;
            dateTimePicker.Enabled = false;

        }

        private void LoadDataIntoComboBox()
        {
            // Rooms
            roomComboBox.DataSource = _dao.GetAllRooms();
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "RoomID";

            // Date
            // pass

            // Films
            filmComboBox.DataSource = _dao.GetAllFilms();
            filmComboBox.DisplayMember = "Title";
            filmComboBox.ValueMember = "FilmID";

            // Slot
            slotComboBox.Items.Clear();

            for (int i = 1; i <= 9; i++)
                slotComboBox.Items.Add(i);

            slotComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Show newShow = new Show
                {
                    RoomID = Convert.ToInt32(roomComboBox.SelectedValue),
                    FilmID = Convert.ToInt32(filmComboBox.SelectedValue),
                    ShowDate = dateTimePicker.Value,
                    Price = Convert.ToDouble(priceTextBox.Text),
                    Status = true,
                    Slot = Convert.ToInt32(slotComboBox.SelectedItem)
                };

                if (show is null)
                {
                    _dao.AddShow(newShow);
                    MessageBox.Show("A new show is added!");
                    this.Close();
                }
                else
                {
                    newShow.ShowID = show.ShowID;
                    _dao.UpdateShow(newShow);
                    MessageBox.Show("That show is edited!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
