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
    public partial class BookingDetailGUI : Form
    {
        private DAO _dao = new DAO();
        private Booking _booking;
        private string seatStatusString = "";
        private int _showId;
        public BookingDetailGUI(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
            seatStatusString = _booking.SeatStatus;
            LoadDataToDetail();
            tbName.Enabled = false;
            tbAmount.Enabled = false;
        }

        public void LoadDataToDetail()
        {
            tbName.Text = _booking.Name;
            tbAmount.Text = Convert.ToString(_booking.Amount) + ".0000";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
