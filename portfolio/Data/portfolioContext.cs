using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Data
{
    public class portfolioContext : DbContext
    {
        public portfolioContext(DbContextOptions<portfolioContext> options)
            : base(options)
        {
        }

        public DbSet<portfolio.Models.PersonalInfo> PersonalInfo { get; set; } = default!;

        public DbSet<portfolio.Models.MyExpertise>? MyExpertise { get; set; }

        public DbSet<portfolio.Models.Education>? Education { get; set; }
    }
}
