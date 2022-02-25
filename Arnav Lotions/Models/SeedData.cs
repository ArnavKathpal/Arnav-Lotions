using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Arnav_Lotions.Data;
using System;
using System.Linq;

namespace Arnav_Lotions.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Arnav_LotionsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Arnav_LotionsContext>>()))
            {
                // Look for any movies.
                if (context.Lotion.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lotion.AddRange(
                    new Lotion
                    {
                        Company = "CERA-V",
                        Type ="Face",
                        Quantity = 150,
                        Fragnance = "Rose",
                        Ingredients = "Oil",
                        Rating = 4,
                        
                    },

                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = ""
                    },

                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },


                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = ""
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                    new Lotion
                    {
                        Company = "",
                        Type = "",
                        Quantity = "",
                        Fragnance = "",
                        Ingredients = "",
                        Rating = "",
                    },
                );;
                context.SaveChanges();
            }
        }
    }
}