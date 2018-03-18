using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using league.Models;
using MySql.Data.MySqlClient;

namespace league.Factory {
    public class NinjaFactory : IFactory<Ninja> {
        private string connectionString;
        public NinjaFactory() {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=dojoLeague;SslMode=None";
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(connectionString);
            }
        }

        public void Add(Ninja ninja) {
            using(IDbConnection dbConnection = Connection) {
                string query = "INSERT INTO ninjas (name, level, description) VALUES (@name, @level, @description)";
                dbConnection.Open();
                dbConnection.Execute(query, ninja);
            }
        }

        public IEnumerable<Ninja> NinjasForDojoId(int id) {
            using (IDbConnection dbConnection = Connection) {
                var query = "SELECT * FROM ninjas JOIN dojos ON ninjas.dojo_id WHERE dojo.id = ninjas.dojo_id AND dojos.id = {id}";
                dbConnection.Open();

                var myNinjas = dbConnection.Query<Ninja, Dojo, Ninja>(query, (ninja, dojo) => { ninja.dojo = dojo; return ninja; });
                return myNinjas;
            }
        }
    }
}