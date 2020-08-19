using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
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