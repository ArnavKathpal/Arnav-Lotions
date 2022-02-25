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
                        Rating = 4
                        
                    },

                    new Lotion
                    {
                        Company = "elf",
                        Type = "Skin",
                        Quantity = 100,
                        Fragnance = "Almond",
                        Ingredients = "Gluitin",
                        Rating = 4
                    },

                    new Lotion
                    {
                        Company = "Neutrogena",
                        Type = "Body",
                        Quantity = 75,
                        Fragnance = "Charcoal",
                        Ingredients = "gel",
                        Rating = 5,
                    },


                    new Lotion
                    {
                        Company = "Embroyolisse",
                        Type = "Skin",
                        Quantity = 100,
                        Fragnance = "rose",
                        Ingredients = "flavours",
                        Rating = 3,
                    },
                    new Lotion
                    {
                        Company = "Manacure",
                        Type = "head",
                        Quantity = 290,
                        Fragnance = "Vanilla",
                        Ingredients = "Flavours",
                        Rating = 4
                    },
                    new Lotion
                    {
                        Company = "Olay",
                        Type = "Body",
                        Quantity = 300,
                        Fragnance = "charcoal",
                        Ingredients = "coal",
                        Rating = 4
                        },
                    new Lotion
                    {
                        Company = "Kale",
                        Type = "skin",
                        Quantity = 250,
                        Fragnance = "Green tea",
                        Ingredients = "Greaan tea",
                        Rating = 4
                    },
                    new Lotion
                    {
                        Company = "Kate",
                        Type = "Face",
                        Quantity = 180,
                        Fragnance = "Charcoal",
                        Ingredients = "oil free",
                        Rating = 5
                    },
                    new Lotion
                    {
                        Company = "Weledia",
                        Type = "face",
                        Quantity = 100,
                        Fragnance = "rose",
                        Ingredients = "gluitin",
                        Rating = 4
                    },
                    new Lotion
                    {
                        Company = "osmia",
                        Type = "face",
                        Quantity = 100,
                        Fragnance = "almond",
                        Ingredients = "oil",
                        Rating = 3
                    }
                );;
                context.SaveChanges();
            }
        }
    }
}