using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication {
    public class Program {
        public static void Main(string[] args) {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================
            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var fromMountVernon = from artist in Artists
            where artist.Hometown == "Mount Vernon"
            select new { artist.RealName, artist.Age };

            foreach (var Artist in fromMountVernon) {
                System.Console.WriteLine(Artist);
            }
            //Who is the youngest artist in our collection of artists?
            var youngestArtist = from artist in Artists
            where
            //Display all artists with 'William' somewhere in their real name

            //Display the 3 oldest artist from Atlanta
        }
    }
}