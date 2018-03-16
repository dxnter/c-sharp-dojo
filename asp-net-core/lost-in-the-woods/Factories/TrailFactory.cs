using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using lost_in_the_woods.Models;
using MySql.Data.MySqlClient;

namespace lost_in_the_woods.Factory {
    public class TrailFactory : IFactory<Trail> {
        private string connectionString;
        public TrailFactory() {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=trailSite;SslMode=None";
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(connectionString);
            }
        }

        public void Add(Trail trail) {
            using (IDbConnection dbConnection = Connection) {
                string query = "INSERT INTO trails (TrailName, Description, TrailLength, Elevation) VALUES (@TrailName, @Description, @TrailLength, @Elevation)";
                dbConnection.Open();
                dbConnection.Execute(query, trail);
            }
        }

        public IEnumerable<Trail> FindAll() {
            using (IDbConnection dbConnection = Connection) {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails");
            }
        }

        public Trail FindByID(int id) {
            using (IDbConnection dbConnection = Connection) {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
    }
}