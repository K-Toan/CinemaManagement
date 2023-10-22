using SE1735_Group6_A2.DAL;
using SE1735_Group6_A2.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SE1735_Group4_A2.GUI
{
    public partial class BookingGUI : Form
    {
        private DAO _dao = new DAO();
        private string seatStatusString = "";
        private int _showId;

        public List<Booking> seatBooked;

        public BookingGUI(int showId)
        {
            InitializeComponent();
            seatBooked = new List<Booking>();
            _showId = showId;
            LoadDataToSeatBooking();
            LoadDataToTableLayout();
            RefreshDataGridView();
            dataGridView.AllowUserToAddRows = false;
        }

        public void LoadDataToSeatBooking()
        {
            DataTable test = _dao.GetAllBookingByShowId(_showId);
            string[] seatBookingTemp = new string[100];
            Array.Fill(seatBookingTemp, "0");

            foreach (DataRow row in test.Rows)
            {
                var ShowId = Convert.ToInt16(row["ShowId"]);
                var Name = Convert.ToString(row["Name"]);
                var SeatStatus = Convert.ToString(row["SeatStatus"]);
                var Amount = Convert.ToInt16(row["Amount"]);
                Booking booking = new Booking
                {
                    ShowID = ShowId,
                    Name = Name,
                    SeatStatus = SeatStatus,
                    Amount = Amount
                };
                for (var i = 0; i < 100; i++)
                {
                    if (booking.SeatStatus[i] == '1')
                    {
                        seatBookingTemp[i] = "1";
                    }
                }
                seatBooked.Add(booking);
            }
            for (int i = 0; i < seatBookingTemp.Length; i++)
            {
                seatStatusString += seatBookingTemp[i];
            }
        }


        public void LoadDataToTableLayout()
        {
            var checkBoxString = seatStatusString;
            for (int i = 0; i < 100; i++)
            {
                System.Windows.Forms.CheckBox checkbox = new System.Windows.Forms.CheckBox();
                checkbox.Text = "Checkbox " + i;
                checkbox.Enabled = false;
                if (checkBoxString[i] == '1')
                {
                    checkbox.Checked = true;
                    bool test = checkbox.Checked;
                    Console.WriteLine(test);
                }
                tlpSeat.Controls.Add(checkbox);
            }
        }

        public void RefreshDataGridView()
        {
            dataGridView.Columns.Clear();
            LoadDataIntoDataGridView();
            AddManagementColumnsIntoDataGridView();
            LoadNumberBooking();
        }
        private void LoadDataIntoDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _dao.GetAllBookingByShowId(_showId);

            dataGridView.Columns["ShowID"].Visible = false;
            dataGridView.Columns["BookingID"].Visible = false;
        }
        private void AddManagementColumnsIntoDataGridView()
        {
            // Add Column Detail Button
            DataGridViewButtonColumn detailColumn = new DataGridViewButtonColumn();
            detailColumn.HeaderText = "Detail";
            detailColumn.Text = "Detail";
            detailColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(detailColumn);

            // Add Column Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteColumn);
        }

        public void LoadNumberBooking()
        {
            lblBookingNumber.Text = seatBooked.Count.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells["BookingID"].Value != null)
            {
                if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Detail")
                {
                    int bookingId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["BookingID"].Value);
                    Booking booking = _dao.GetBookingById(bookingId);
                    if (booking != null)
                    {
                        BookingDetailGUI bookingDetailGUI = new BookingDetailGUI(booking);
                        bookingDetailGUI.Show();
                    }
                }
                else if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    int bookingId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["BookingID"].Value);
                    if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _dao.DeleteBooking(bookingId);
                        RefreshBookingGUI(sender, e);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            BookingAddGUI bookingAddGUI = new BookingAddGUI(_showId);
            bookingAddGUI.BookingAdded += RefreshBookingGUI;
            bookingAddGUI.Show();
        }

        private void RefreshBookingGUI(object sender, EventArgs e)
        {
            tlpSeat.Controls.Clear();

            RefreshDataGridView();
            seatBooked = new List<Booking>();
            seatStatusString = "";
            LoadDataToSeatBooking();
            LoadDataToTableLayout();
        }

    }

}
