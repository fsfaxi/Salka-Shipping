
using System;
using Microsoft.EntityFrameworkCore;
using PackageManagment.Domain.Models;

namespace PackageManagment.Infra
{
    public class PMContext : DbContext
    {
        public PMContext(DbContextOptions<PMContext> options)
            : base(options)
        {
        }

        public DbSet<PackageItem> PackageItems { get; set; }
    }
}
