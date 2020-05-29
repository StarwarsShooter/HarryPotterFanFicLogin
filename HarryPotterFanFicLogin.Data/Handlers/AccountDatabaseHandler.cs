using MySql.Data.MySqlClient;
using HarryPotterFanFicLogin.Data.Entities;
using HarryPotterFanFicLogin.Interfaces;
using HarryPotterFanFicLogin.Interfaces.Handlers;
using System.Collections.Generic;

namespace HarryPotterFanFicLogin.Data.Handlers
{
    public class AccountDatabaseHandler : IAccountDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public List<IAccount> GetAllAccounts()
        {
            List<IAccount> Accounts = new List<IAccount>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM account";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Account dto = new Account();
                        //dto.ID = reader.GetInt32(0);
                        //Accounts.Add(dto);
                    }
                }
            }
            return Accounts;
        }
        public void CreateAccount(IAccount A1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Account VALUES( @FirstName,@Preposition,@LastName,@Email,@Password,@PhoneNumber,@Street,@HouseNumber,@Addition,@PostalCode,@City,@Birthdate); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    //command.Parameters.AddWithValue("@FirstName", A1.FirstName);
                    //command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateAccount(IAccount A1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE account SET Firstname = @FirstName, Preposition = @Preposition, LastName=@LastName,Email=@Email,Password=@Password,PhoneNumber=@PhoneNumber,Street=@Street,Addition=@Addition,PostalCode=@PostalCode,City=@City,Birthdate=@Birthdate WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    //command.Parameters.AddWithValue("@ID", A1.ID);
                    //command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteAccount(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM account WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IAccount GetById(IAccount account)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM account WHERE ID = @ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    //command.Parameters.AddWithValue("@ID", account.ID);

                }
            }
            return account;
        }
    }
}