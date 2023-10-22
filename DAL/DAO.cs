using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SE1735_Group6_A2.DTL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1735_Group6_A2.DAL
{
    public class DAO
    {
        private DataSet _dataSet;
        public DAO()
        {
            _dataSet = new DataSet();
            LoadData();
        }
        public bool Login(string username, string password)
        {
            try
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                string adminUsername = configuration["AdminAccount:Username"];
                string adminPassword = configuration["AdminAccount:Password"];
                if (username == adminUsername && password == adminPassword)
                {
                    AppSettings.IsLoggedIn = true;
                    return true;
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Error deserializing JSON: " + ex.Message);
            }

            return false;
        }
        public void Logout()
        {
            AppSettings.IsLoggedIn = false;
        }

        public bool checkLogin()
        {
            return AppSettings.IsLoggedIn;
        }

        private void LoadData()
        {
            // Create object connection
            SqlConnection conn = new SqlConnection(AppSettings.ConnectionString);

            // Create object Command
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shows; SELECT * FROM Films; SELECT * FROM Rooms; SELECT * FROM Genres", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill data from database into DataSet ds
            adapter.Fill(_dataSet);
        }

        public void AddShow(Show show)
        {
            string query = "INSERT INTO Shows VALUES (@roomID, @filmID, @showDate, @price, @status, @slot)";

            using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
            using (SqlCommand insertCommand = new SqlCommand(query, conn))
            {
                insertCommand.Parameters.AddWithValue("@roomID", show.RoomID);
                insertCommand.Parameters.AddWithValue("@filmID", show.FilmID);
                insertCommand.Parameters.AddWithValue("@showDate", show.ShowDate);
                insertCommand.Parameters.AddWithValue("@price", show.Price);
                insertCommand.Parameters.AddWithValue("@status", true);
                insertCommand.Parameters.AddWithValue("@slot", show.Slot);

                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateShow(Show show)
        {
            string query = "UPDATE Shows SET RoomID = @RoomID, FilmID = @FilmID, ShowDate = @ShowDate, Price = @Price, Slot = @Slot WHERE ShowID = @ShowID";
            using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
            using (SqlCommand updateCommand = new SqlCommand(query, conn))
            {
                updateCommand.Parameters.AddWithValue("@ShowID", show.ShowID);
                updateCommand.Parameters.AddWithValue("@RoomID", show.RoomID);
                updateCommand.Parameters.AddWithValue("@FilmID", show.FilmID);
                updateCommand.Parameters.AddWithValue("@ShowDate", show.ShowDate);
                updateCommand.Parameters.AddWithValue("@Price", show.Price);
                updateCommand.Parameters.AddWithValue("@Slot", show.Slot);

                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteShow(int showId)
        {
            try
            {
                string query = "DELETE FROM Shows WHERE ShowID = @ShowID";

                using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
                using (SqlCommand deleteCommand = new SqlCommand(query, conn))
                {
                    deleteCommand.Parameters.AddWithValue("@ShowID", showId);

                    conn.Open();
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable GetAllShows()
        {
            DataTable showsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Shows";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(showsTable);
                }
            }

            return showsTable;
        }
        public void AddBooking(Booking booking)
        {
            string query = "INSERT INTO Bookings VALUES (@ShowID, @Name, @SeatStatus, @Amount)";

            using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
            using (SqlCommand insertCommand = new SqlCommand(query, conn))
            {
                insertCommand.Parameters.AddWithValue("@ShowID", booking.ShowID);
                insertCommand.Parameters.AddWithValue("@Name", booking.Name);
                insertCommand.Parameters.AddWithValue("@SeatStatus", booking.SeatStatus);
                insertCommand.Parameters.AddWithValue("@Amount", booking.Amount);

                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
        public Show GetShowById(int showID)
        {
            Show show = null;

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Shows WHERE ShowID = @ShowID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShowID", showID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            show = new Show
                            {
                                ShowID = Convert.ToInt32(reader["ShowID"]),
                                RoomID = Convert.ToInt32(reader["RoomID"]),
                                FilmID = Convert.ToInt32(reader["FilmID"]),
                                ShowDate = Convert.ToDateTime(reader["ShowDate"]),
                                Price = Convert.ToDouble(reader["Price"]),
                                Status = true,
                                Slot = Convert.ToInt32(reader["Slot"])
                            };
                        }
                    }
                }

                connection.Close();
            }

            return show;
        }

        public bool CheckAvailableSlot(int RoomID, string ShowDate, int Slot)
        {

            using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
            {
                conn.Open();
                string query = "select * from Shows where RoomID = @RoomID and slot = @Slot and ShowDate = @ShowDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    cmd.Parameters.AddWithValue("@Slot", Slot);
                    cmd.Parameters.AddWithValue("@ShowDate", ShowDate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public DataTable GetShows(int filmId, DateTime showDate, int roomId)
        {
            DataTable showsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Shows WHERE FilmID = @FilmID AND ShowDate = @ShowDate AND RoomID = @RoomID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FilmID", filmId);
                    command.Parameters.AddWithValue("@ShowDate", showDate.Date); // Lấy ngày, tháng, năm từ DateTime
                    command.Parameters.AddWithValue("@RoomID", roomId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(showsTable);
                    }
                }
                connection.Close();
            }

            return showsTable;
        }
        public DataTable GetAllBooking()
        {
            DataTable showsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Bookings";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(showsTable);
                }
            }

            return showsTable;
        }
        public DataTable GetAllBookingByShowId(int showId)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Bookings WHERE ShowID = @ShowID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShowID", showId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(bookingsTable);
                    }
                }

            }

            return bookingsTable;
        }

        public Booking GetBookingById(int id)
        {
            Booking booking = null;
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Bookings WHERE BookingID = @BookingID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            booking = new Booking
                            {
                                ShowID = Convert.ToInt32(reader["ShowID"]),
                                BookingID = Convert.ToInt32(reader["BookingID"]),
                                Name = Convert.ToString(reader["Name"]),
                                SeatStatus = Convert.ToString(reader["SeatStatus"]),
                                Amount = Convert.ToInt32(reader["Amount"]),
                            };
                        }
                    }
                }

                connection.Close();
            }

            return booking;
        }

        public void DeleteBooking(int bookingId)
        {
            try
            {
                string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";

                using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionString))
                using (SqlCommand deleteCommand = new SqlCommand(query, conn))
                {
                    deleteCommand.Parameters.AddWithValue("@BookingID", bookingId);

                    conn.Open();
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable GetAllFilms()
        {
            DataTable filmsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Films";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(filmsTable);
                }
                connection.Close();
            }

            return filmsTable;
        }

        public DataTable GetAllRooms()
        {
            DataTable roomsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Rooms";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(roomsTable);
                }
                connection.Close();
            }

            return roomsTable;
        }

        public DataTable GetAllGenres()
        {
            DataTable shoesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Shoes";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(shoesTable);
                }
                connection.Close();
            }

            return shoesTable;
        }

    }
}
