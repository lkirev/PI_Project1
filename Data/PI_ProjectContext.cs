using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PI_Project.Models;

namespace PI_Project.Data
{
    public class PI_ProjectContext : DbContext
    {
        public PI_ProjectContext (DbContextOptions<PI_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PI_Project.Models.Part> Part { get; set; }

        public DbSet<PI_Project.Models.User> User { get; set; }
    }
}
