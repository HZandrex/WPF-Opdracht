using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Collections.Generic;

using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Nico_Claes_r0661818_2ITF1.Extensions;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    class AccountDataService
    {
        // ophalen ConnectionString uit App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["auth"].ConnectionString;

        // connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new MySqlConnection(connectionString);

        // return een collectie van accounts
        public ObservableCollection<Account> GetAccounts()
        {
            string sql = "SELECT * FROM accounts";

            return (ObservableCollection<Account>)db.Query<Account>(sql).ToObservableCollection();
        }

        // return een id dat overeen komt met opgegeven username
        public int GetIdByUsername(string username)
        {
            string sql = "SELECT id FROM accounts where username = @username";

            return db.Query<int>(sql, new { username}).First();
        }

        // toevoegen van account
        public void InsertAccount(Account account)
        {
            // SQL statement insert
            string sql = "Insert into accounts (username, nickname, password, salt, securityLevel) values (@username, @nickname, @password, @salt, @securityLevel)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                account.Username,
                account.Nickname,
                account.Password,
                account.Salt,
                account.SecurityLevel
            });
        }

        public void DeleteAccount(int id)
        {
            // SQL statement delete 
            string sql = "Delete from accounts where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { id });
        }

        public void UpdateAccount(Account account)
        {
            // SQL statement update 
            string sql = "Update Accounts set username = @username, password = @password, salt= @salt, securityLevel = @securityLevel where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                account.Username,
                account.Password,
                account.Salt,
                account.SecurityLevel,
                account.Id
            });
        }

    }
}
