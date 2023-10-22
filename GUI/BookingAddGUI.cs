using Microsoft.IdentityModel.Tokens;
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

namespace SE1735_Group4_A2.GUI
{
    public partial class BookingAddGUI : Form
    {
        private DAO _dao = new DAO();

        public List<Booking> seatBooked;
        private string seatStatusString = "";
        private int _showId;
        private static string[] seatBookingChoice;
        public event EventHandler BookingAdded;

        public BookingAddGUI(int showId)
        {
            _showId = showId;
            InitializeComponent();
            seatBooked = new List<Booking>();
            LoadDataToSeatBooking();
            LoadDataToTableLayout();
            AddEventCheckBoxChange();
            seatBookingChoice = new string[100];
            Array.Fill(seatBookingChoice, "0");

        }
        public List<Booking> LoadDataToSeatBooking()
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
            return seatBooked;
        }
        public void CheckBoxAndDisable(CheckBox checkBox)
        {
            checkBox.Checked = true;
            checkBox.Enabled = false;
        }

        public void LoadDataToTableLayout()
        {
            var checkBoxString = seatStatusString;
            for (int i = 0; i < 100; i++)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Text = "Checkbox " + i;
                if (checkBoxString[i] == '1')
                {
                    CheckBoxAndDisable(checkbox);
                }
                tlpSeat.Controls.Add(checkbox);
            }
        }

        public void AddEventCheckBoxChange()
        {
            foreach (CheckBox checkbox in tlpSeat.Controls)
            {
                Show show = _dao.GetShowById(_showId);
                int i = Convert.ToInt16(checkbox.Text.Split(" ")[1]);
                checkbox.CheckedChanged += (sender, e) =>
                {
                    if (checkbox.Checked)
                    {
                        seatBookingChoice[i] = "1";
                        if (tbAmount.Text.IsNullOrEmpty())
                        {
                            tbAmount.Text = "10.0000";
                        }
                        else
                        {
                            tbAmount.Text = Convert.ToString(
                                Convert.ToInt16(tbAmount.Text.Split(".")[0]) + show.Price) + ".0000";
                        }
                    }
                    else
                    {
                        seatBookingChoice[i] = "0";
                        if (tbAmount.Text.Equals("10.0000"))
                        {
                            tbAmount.Text = "";
                        }
                        else
                        {
                            tbAmount.Text = Convert.ToString(
                                Convert.ToInt16(tbAmount.Text.Split(".")[0]) - show.Price) + ".0000";
                        }
                    }
                };
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            Show show = _dao.GetShowById(_showId);

            // Get Data
            string[] choices = seatBookingChoice;
            string seatStatus = "";
            int count = 0;
            foreach (var item in choices)
            {
                if (item.Equals("1"))
                {
                    count++;
                }
                seatStatus += item;
            }

            booking.Name = tbName.Text;
            booking.SeatStatus = seatStatus;
            booking.Amount = Convert.ToInt32(count * show.Price);
            booking.ShowID = show.ShowID;

            // Validate
            if (booking.Name.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter name");
            }
            else
            {
                _dao.AddBooking(booking);
                OnBookingAdded();
                Close();
            }
        }


        protected void OnBookingAdded()
        {
            EventHandler handler = BookingAdded;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
