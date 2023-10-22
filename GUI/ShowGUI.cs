using SE1735_Group4_A2.GUI;
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
    public partial class ShowGUI : Form
    {
        private DAO _dao = new DAO();

        public ShowGUI()
        {
            InitializeComponent();
            HideAllItems();
            LoadDataIntoComboBox();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Columns.Clear();
            LoadDataIntoDataGridView();
            AddBookingColumnsIntoDataGridView();
            if (AppSettings.IsLoggedIn)
                AddManagementColumnsIntoDataGridView();
        }

        private void LoadDataIntoComboBox()
        {
            // Films
            filmComboBox.DataSource = _dao.GetAllFilms();
            filmComboBox.DisplayMember = "Title";
            filmComboBox.ValueMember = "FilmID";

            // Rooms
            roomComboBox.DataSource = _dao.GetAllRooms();
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "RoomID";

            // Date
            // pass
        }

        private void LoadDataIntoDataGridView()
        {
            dataGridView.DataSource = null;
            // Gán danh sách shows vào DataGridView
            dataGridView.DataSource = _dao.GetAllShows();

            dataGridView.Columns["ShowID"].Visible = false;
            dataGridView.Columns["Status"].Visible = false;

            numberOfShowsLabel.Text = "The number of shows:  " + dataGridView.Rows.Count;
        }

        private void AddBookingColumnsIntoDataGridView()
        {
            // Add Column Booking
            DataGridViewButtonColumn bookingColumn = new DataGridViewButtonColumn();
            bookingColumn.HeaderText = "Booking";
            bookingColumn.Text = "Booking";
            bookingColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(bookingColumn);
        }

        private void AddManagementColumnsIntoDataGridView()
        {
            // Add Column Update Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(editColumn);

            // Add Column Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteColumn);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Booking")
                {
                    int showId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ShowID"].Value);
                    BookingGUI booking = new BookingGUI(showId);
                    booking.ShowDialog();
                }
                else if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    int showId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ShowID"].Value);
                    Show show = _dao.GetShowById(showId);
                    if (show != null)
                    {
                        ShowAddEditGUI showAddEditGUI = new ShowAddEditGUI(show);
                        showAddEditGUI.ShowDialog();
                        RefreshDataGridView();
                    }
                }
                else if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    int showId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ShowID"].Value);
                    if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _dao.DeleteShow(showId);
                        RefreshDataGridView();
                    }
                    else
                    {

                    }
                }
            }
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
            if (AppSettings.IsLoggedIn)
            {
                addNewButton.Visible = true;
                loginToolStripMenuItem.Text = "Logout (admin)";
            }
            else
            {
                addNewButton.Visible = false;
                loginToolStripMenuItem.Text = "Login";
            }
            RefreshDataGridView();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int filmId = Convert.ToInt32(filmComboBox.SelectedValue);
            DateTime showDate = Convert.ToDateTime(dateTimePicker.Value.Date);
            int roomId = Convert.ToInt32(roomComboBox.SelectedValue);
            dataGridView.DataSource = _dao.GetShows(filmId, showDate, roomId);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            ShowAddEditGUI showAddEditGUI = new ShowAddEditGUI();
            showAddEditGUI.ShowDialog();
            RefreshDataGridView();
        }

        private void HideAllItems()
        {
            filmLabel.Visible = false;
            dateLabel.Visible = false;
            roomLabel.Visible = false;

            filmComboBox.Visible = false;
            dateTimePicker.Visible = false;
            roomComboBox.Visible = false;

            searchButton.Visible = false;
            addNewButton.Visible = false;
            numberOfShowsLabel.Visible = false;

            dataGridView.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmLabel.Visible = true;
            dateLabel.Visible = true;
            roomLabel.Visible = true;

            filmComboBox.Visible = true;
            dateTimePicker.Visible = true;
            roomComboBox.Visible = true;

            searchButton.Visible = true;
            numberOfShowsLabel.Visible = true;

            dataGridView.Visible = true;
        }
    }
}
