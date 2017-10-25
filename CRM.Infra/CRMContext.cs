using System;
using Microsoft.EntityFrameworkCore;
using CRM.Domain.Models;


namespace CRM.Infra
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Package> Packages { get; set; }


    }
}
