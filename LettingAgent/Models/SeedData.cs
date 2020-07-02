using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LettingAgent.Data;
using System;
using System.Linq;

namespace LettingAgent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Property.Any())
                {
                    return;   // DB has been seeded
                }

                context.Property.AddRange(
                    new Property
                    {
                        Address1 = "1 Home Street",
                        City = "Edinburgh",
                        Area = "Midlothian",
                        PostCode = "EH1 1AB",
                        PictureUrl = "https://images.unsplash.com/photo-1560026301-88340cf16be7?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2134&q=80",
                        DepositAmount = 5000,
                        Rent = 4500,
                        NumberOfBedrooms = 5,
                        ShortDescription = "Grand house on the outskirts of Edinburgh",
                        Description = "Nice if you can afford it",
                        AvailableDate = new DateTime(2020, 7, 15)
                    },
                    new Property
                    {
                        Address1 = "20 Lesser Street",
                        Address2 = "Someplace",
                        City = "Edinburgh",
                        Area = "Midlothian",
                        PostCode = "EH3 2BC",
                        PictureUrl = "https://images.unsplash.com/photo-1434082033009-b81d41d32e1c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
                        DepositAmount = 1000,
                        Rent = 750,
                        NumberOfBedrooms = 2,
                        ShortDescription = "Cute little place, looks surprisingly American",
                        Description = "Good for people on a budget who don't mind being cosy",
                        AvailableDate = new DateTime(2020, 8, 1)
                    },

                    new Property
                    {
                        Address1 = "23 Small Street",
                        Address2 = "Noplace",
                        City = "Edinburgh",
                        Area = "Midlothian",
                        PostCode = "EH5 9XY",
                        PictureUrl = "https://images.unsplash.com/photo-1502304104451-b61947b321ca?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1267&q=80",
                        DepositAmount = 500,
                        Rent = 500,
                        NumberOfBedrooms = 1,
                        ShortDescription = "Small but perfectly formed 1 bedroom flat",
                        Description = "Nice if you don't spend too much time here",
                        AvailableDate = new DateTime(2020, 7, 25)
                    },

                    new Property
                    {
                        Address1 = "1 Little Road",  
                        Address2 = "Anotherplace",
                        City = "Edinburgh",
                        Area = "Midlothian",
                        PostCode = "EH20 1AB",
                        PictureUrl = "https://images.unsplash.com/photo-1556738609-38bc26f37cec?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=675&q=80",
                        DepositAmount = 450,
                        Rent = 450,
                        NumberOfBedrooms = 1,
                        ShortDescription = "Small lodge style place",
                        Description = "More of a static caravan than a house, but nice if that's what you want",
                        AvailableDate = new DateTime(2020, 8, 1)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}