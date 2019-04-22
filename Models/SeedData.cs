using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lab11.Models{

    public static class SeedData
    {   
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(
                serviceProvider.GetService<
                DbContextOptions<ProfessorDbContext>>()))
                {
                    if (context.Professor.Any())
                    {
                        return;
                    }

                    context.Professor.AddRange(
                        new Professor
                        {
                            FirstName = "Kareem", 
                            LastName = "Dana"
                        },
                        new Professor
                        {
                            FirstName = "Jeffery",
                            LastName = "Babb"
                        },
                        new Professor
                        {
                            FirstName = "Amjad",
                            LastName = "Abdallat"
                        }
                    );
                    context.SaveChanges();
                }
        }
    }
}