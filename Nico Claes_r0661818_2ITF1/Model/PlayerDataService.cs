using Dapper;
using MySql.Data.MySqlClient;
using Nico_Claes_r0661818_2ITF1.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    class PlayerDataService
    {// ophalen ConnectionString uit App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["game"].ConnectionString;

        // connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new MySqlConnection(connectionString);

        // return een specifieke player dankzij opgegeven id
        public Player GetPlayerById(int id)
        {
            string sql = "SELECT * FROM players where id = @id";

            return db.Query<Player>(sql, new { id }).SingleOrDefault();
        }

        // toevoegen van player
        public void InsertPlayer(Player player)
        {
            // SQL statement insert
            string sql = "Insert into players (id, tutorialState, level, totalExperience, pen, ap, coins1, coins2, currentCharacterSlot) values (@id, @tutorialState, @level, @totalExperience, @pen, @ap, @coins1, @coins2, @currentCharacterSlot)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                player.Id,
                player.TutorialState,
                player.Level,
                player.TotalExperience,
                player.Pen,
                player.Ap,
                player.Coins1,
                player.Coins2,
                player.CurrentCharacterSlot
            });
        }

        public void DeletePlayer(int id)
        {
            // SQL statement delete 
            string sql = "Delete from players where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { id });
        }

        public void UpdatePlayer(Player player)
        {
            // SQL statement update 
            string sql = "Update players set tutorialState = @tutorialState, level = @level, totalExperience = @totalExperience, pen = @pen, ap = @ap, coins1 = @coins1, coins2 = @coins2, currentCharacterSlot = @currentCharacterSlot where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                player.TutorialState,
                player.Level,
                player.TotalExperience,
                player.Pen,
                player.Ap,
                player.Coins1,
                player.Coins2,
                player.CurrentCharacterSlot,
                player.Id
            });
        }
    }
}
