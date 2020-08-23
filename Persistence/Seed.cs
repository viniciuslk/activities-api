using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "Bob",
                        UserName = "bob",
                        Email = "bob@bob.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Dylan",
                        UserName = "dylan",
                        Email = "dylan@dylan.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Patrick Jane",
                        UserName = "jane",
                        Email = "jane@jane.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
            
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months later",
                        Category = "music",
                        City = "London",
                        Venue = "02 Arena"
                    },
                    new Activity
                    {
                        Title = "Future Activity",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Activity 2 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "02 Arena"
                    },
                };
                
                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}