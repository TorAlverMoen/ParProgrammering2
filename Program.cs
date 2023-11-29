using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering2
{
    class MovieInfo
    {
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Actor1 { get; set; }
        public string Actor2 { get; set; }

        public MovieInfo(string title, string releaseYear, string description, string director, string actor1, string actor2)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Description = description;
            Director = director;
            Actor1 = actor1;
            Actor2 = actor2;
        }
    }

    internal class Program
    {
        static void DisplayMovieInfo(string title, string year, string description, string director, string actor1, string actor2)
        {
            Console.WriteLine($"Film tittel: {title}");
            Console.WriteLine($"Filmen ble sluppet i {year}");
            Console.WriteLine($"Beskrivelse av filmen: {description}");
            Console.WriteLine($"Regissør: {director}");
            Console.WriteLine($"Hovedrolle innehavere er: {actor1} og {actor2}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<MovieInfo> listOfMovies = new List<MovieInfo>();
            string answer = "j";
            string title = "";
            string year = "";
            string description = "";
            string director = "";
            string actor1 = "";
            string actor2 = "";

            while (answer.ToLower() != "n")
            {
                Console.Write("Hva er film tittelen? ");
                title = Console.ReadLine();
                Console.Write("Når ble filmen sluppet? ");
                year = Console.ReadLine();
                Console.Write("Hva handler filmen om? ");
                description = Console.ReadLine();
                Console.Write("Hvem er regissør? ");
                director = Console.ReadLine();
                Console.Write("Hvem har hovedrollen?");
                actor1 = Console.ReadLine();
                Console.Write("Hvem har den andre hovedrollen?");
                actor2 = Console.ReadLine();

                listOfMovies.Add(new MovieInfo(title, year, description, director, actor1, actor2));

                Console.WriteLine();
                Console.Write("Vil du legge til en ny film (J/N) ?");
                answer = Console.ReadLine();

                Console.WriteLine();

            }

            Console.WriteLine($"Antall filmer: {listOfMovies.Count}");
            Console.WriteLine();

            for (int i = 0; i < listOfMovies.Count; i++)
            {
                DisplayMovieInfo(listOfMovies[i].Title, listOfMovies[i].ReleaseYear, listOfMovies[i].Description,
                    listOfMovies[i].Director, listOfMovies[i].Actor1, listOfMovies[i].Actor2);
            }
        }
    }
}
