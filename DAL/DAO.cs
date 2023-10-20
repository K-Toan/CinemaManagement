using Microsoft.Data.SqlClient;
using SE1735_Group6_A2.DTL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1735_Group6_A2.DAL
{
    public class DAO
    {
        private static readonly string connectionString = "Data Source=TOAN;Initial Catalog=Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private DataSet _dataSet;
        public DAO()
        {
            _dataSet = new DataSet();
            LoadData();
        }

        private void LoadData()
        {
            // Create object connection
            SqlConnection conn = new SqlConnection(connectionString);

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

            using (SqlConnection conn = new SqlConnection(connectionString))
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
            using (SqlConnection conn = new SqlConnection(connectionString))
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

                using (SqlConnection conn = new SqlConnection(connectionString))
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

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        public Show GetShowById(int showID)
        {
            Show show = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
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
        public DataTable GetShows(int filmId, DateTime showDate, int roomId)
        {
            DataTable showsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
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


        public DataTable GetAllFilms()
        {
            DataTable filmsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
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

            using (SqlConnection connection = new SqlConnection(connectionString))
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

            using (SqlConnection connection = new SqlConnection(connectionString))
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
