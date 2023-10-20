using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SE1735_Group6_A2.Repository
{
    public class AccountRepository
    {
        public static bool isLoggedIn = false;
        public AccountRepository()
        {
        }

        public bool Login(string username, string password)
        {
            try
            {
                // Read "appsettings.json"
                //string jsonContent = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"));

                // Deserialize JSON
                //Account acc = JsonSerializer.Deserialize<Account>(jsonContent);

                if (username == "admin" && password == "admin")
                {
                    isLoggedIn = true;
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
            isLoggedIn = false;
        }

        public bool checkLogin()
        {
            return isLoggedIn;
        }
    }
}
