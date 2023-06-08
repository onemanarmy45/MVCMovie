using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "A Beautiful Mind",
                    ReleaseDate = DateTime.Parse("12-13-2001"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 14M
                },
                new Movie
                {
                    Title = "Ferris Bueller's Day Off",
                    ReleaseDate = DateTime.Parse("06-11-1986"),
                    Genre = "Comedy",
                    Rating = "XXX",
                    Price = 14M
                },
                new Movie
                {
                    Title = "Zodiac",
                    ReleaseDate = DateTime.Parse("03-02-2007"),
                    Genre = "Thriller",
                    Rating = "PG",
                    Price = 12M
                },
                new Movie
                {
                    Title = "Juno",
                    ReleaseDate = DateTime.Parse("12-05-2007"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 12M
                }
            );
            context.SaveChanges();
        }
    }
}