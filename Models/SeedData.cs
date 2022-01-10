using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PI_Project.Data;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace PI_Project.Models
{
    public static class SeedData
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PI_ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PI_ProjectContext>>()))
            {
                if (context.Part.Any())
                {
                    return;
                }
                if (context.User.Any())
                {
                    return;
                }

/*                context.User.AddRange(
                    new User
                    {
                        Name = "Pesho",
                        Pass = MyHash.Hash("test")
                    },

                    new User
                    {
                        Name = "Ivan",
                        Pass = MyHash.Hash("test123")
                    }
                    );*/
                context.SaveChanges();
            }
        }
    }
}
