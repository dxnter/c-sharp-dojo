using System;
using DbConnection;

namespace simple_crud {
    class Program {
        static void Main(string[] args) {
            Create("Danny", "Foster", 12);
            Read();
        }

        public static void Read() {
            var users = DbConnector.Query("SELECT * FROM users");
            foreach (var user in users) {
                foreach (var prop in user) {
                    System.Console.WriteLine(prop);
                }
            }
        }

        public static void Create(string first, string last, int number) {
            DbConnector.Execute($"INSERT INTO users (FirstName, LastName, FavoriteNumber) VALUES ('{first}', '{last}', '{number}')");
            System.Console.WriteLine($"{first} {last} successfully added to the database!");
        }
    }
}