using System;
using System.Collections.Generic;
using MovieApp; 

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie("Toy Story", "animated"),
            new Movie("The Godfather", "drama"),
            new Movie("The Conjuring", "horror"),
            new Movie("Inception", "scifi"),
            new Movie("Finding Nemo", "animated"),
            new Movie("Titanic", "drama"),
            new Movie("A Nightmare on Elm Street", "horror"),
            new Movie("Interstellar", "scifi"),
            new Movie("Shrek", "animated"),
            new Movie("The Shawshank Redemption", "drama")
        };

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter a category (animated, drama, horror, scifi):");
            string category = Console.ReadLine().ToLower();

            List<Movie> filteredMovies = movies.FindAll(m => m.Category.ToLower() == category);

            if (filteredMovies.Count > 0)
            {
                Console.WriteLine($"Movies in the {category} category:");
                foreach (Movie movie in filteredMovies)
                {
                    Console.WriteLine(movie.Title);
                }
            }
            else
            {
                Console.WriteLine("No movies found in that category.");
            }

            Console.WriteLine("Do you want to continue? (yes/no):");
            string continueResponse = Console.ReadLine().ToLower();
            continueProgram = continueResponse == "yes";
        }
    }
}
