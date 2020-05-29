using MySql.Data.MySqlClient;
using HarryPotterFanFicLogin.Data.Entities;
using HarryPotterFanFicLogin.Interfaces;
using HarryPotterFanFicLogin.Interfaces.Handlers;
using System.Collections.Generic;

namespace HarryPotterFanFicLogin.Data.Handlers
{
    public class ForumPostDatabaseHandler : IForumPostDatabaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
    }
}