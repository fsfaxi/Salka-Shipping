using PM.Domain.Models;
using PackageManagment.Infra;
using System;
using System.Linq;

namespace PackageManagment.Infra.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PMContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.PackageItems.Any())
            {
                return;   // DB has been seeded
            }

            var pkg_itmes = new PackageItem[]
            {
            new PackageItem{sender_first_name="Alexander", receiver_first_name="Mike"},
            new PackageItem{sender_first_name="Sam", receiver_first_name="Foo"}

            };
            foreach (PackageItem s in pkg_itmes)
            {
                context.PackageItems.Add(s);
            }
            context.SaveChanges();

           
        }
    }
}


