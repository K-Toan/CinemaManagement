using SE1735_Group6_A2.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace SE1735_Group6_A2.Repository
{
    public class ShowRepository
    {
        public static readonly string connectionString = "Data Source=TOAN;Initial Catalog=Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public ShowRepository()
        { }

        public List<Show> GetAllShows()
        {
            List<Show> shows = new List<Show>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Shows";
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        shows.Add(new Show
                        {
                            ShowID = Convert.ToInt32(reader["ShowID"]),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            FilmID = Convert.ToInt32(reader["FilmID"]),
                            ShowDate = Convert.ToDateTime(reader["ShowDate"]),
                            Price = Convert.ToDouble(reader["Price"]),
                            Status = Convert.ToBoolean(reader["Status"]),
                            Slot = Convert.ToInt32(reader["Slot"])
                        });
                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return shows;
        }

    }
}
