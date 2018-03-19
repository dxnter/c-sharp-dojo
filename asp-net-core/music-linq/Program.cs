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
            var fromMountVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").ToList();
            foreach(var artist in fromMountVernon) {
                System.Console.WriteLine(artist.RealName);
                System.Console.WriteLine(artist.Age);
            }
            //Who is the youngest artist in our collection of artists?
            var youngestArtist = Artists.OrderBy(artist => artist.Age).FirstOrDefault();
            System.Console.WriteLine(youngestArtist.RealName);
            //Display all artists with 'William' somewhere in their real name
            var containsWilliam = Artists.Where(artist => artist.RealName.Contains("William")).ToList();
            foreach(var artist in containsWilliam) {
                System.Console.WriteLine(artist.RealName);
            }
            //Display the 3 oldest artist from Atlanta
            var oldestInAtlanta = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3).ToList();
            foreach(var artist in oldestInAtlanta) {
                System.Console.WriteLine($"{artist.ArtistName} {artist.Age}");
            }

            //Display the group name of all groups that have members that are not from New York City
            var notFromNewYork = Group.
            // Display the artist names of all members in the group Wu-Tang Clan

        }
    }
}