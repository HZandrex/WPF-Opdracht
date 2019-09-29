using Dapper;
using MySql.Data.MySqlClient;
using Nico_Claes_r0661818_2ITF1.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    class BanDataService
    {
        // ophalen ConnectionString uit App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["auth"].ConnectionString;

        // connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new MySqlConnection(connectionString);

        public bool CheckBanExistByAccountId(int accountId)
        {
            string sql = "SELECT count(1) FROM bans where  accountId = @accountId";

            return db.ExecuteScalar<bool>(sql, new { accountId }); ;
        }

        // return een specifiek ban informatie
        public Ban GetBanByAccountId(int accountId)
        {
            Trace.WriteLine("check id: " + accountId);
            string sql = "SELECT * FROM bans where accountId = @accountId";

            return db.Query<Ban>(sql, new { accountId }).SingleOrDefault();
        }

        // toevoegen van ban
        public void InsertBan(Ban ban)
        {
            // SQL statement insert
            string sql = "Insert into bans (accountId, date, duration, reason) values (@accountId, @date, @duration, @reason)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                ban.AccountId,
                ban.Date,
                ban.Duration,
                ban.Reason
            });
        }

        public void DeleteBan(int accountId)
        {
            // SQL statement delete 
            string sql = "Delete from bans where accountId = @accountId";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { accountId });
        }

        public void UpdateBan(Ban ban)
        {
            // SQL statement update 
            string sql = "Update Bans set accountId = @accountId, date = @date, duration= @duration, reason = @reason where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                ban.AccountId,
                ban.Date,
                ban.Duration,
                ban.Reason,
                ban.Id
            });
        }
    }
}
