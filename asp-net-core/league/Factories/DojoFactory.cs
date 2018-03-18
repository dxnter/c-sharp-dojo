using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using league.Models;
using MySql.Data.MySqlClient;

namespace league.Factory {
    public class DojoFactory : IFactory<Dojo> {
        private string connectionString;
        public DojoFactory() {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=dojoLeague;SslMode=None";
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(connectionString);
            }
        }

        public Dojo FindByID(long id) {
            using(IDbConnection dbConnection = Connection) {
                dbConnection.Open();
                var query =
                    @"
                SELECT * FROM dojos WHERE id = @Id;
                SELECT * FROM ninjas WHERE dojo_id = @Id;
                ";

                using(var multi = dbConnection.QueryMultiple(query, new { Id = id })) {
                    var dojo = multi.Read<Dojo>().Single();
                    dojo.ninjas = multi.Read<Ninja>().ToList();
                    return dojo;
                }
            }
        }
    }
}