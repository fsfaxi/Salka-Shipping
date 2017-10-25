using CRM.Domain.Models;
using CRM.Infra;
using System;
using System.Linq;

namespace CRM.Infra.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CRMContext context)
        {
            //context.Database.EnsureCreated();

            //// Look for any students.
            //if (context.Customers.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var pkg_itmes = new Customer[]
            //{
            //new Customer{sender_first_name="Alexander", receiver_first_name="Mike"},
            //new Customer{sender_first_name="Sam", receiver_first_name="Foo"}

            //};
            //foreach (PackageItem s in pkg_itmes)
            //{
            //    context.PackageItems.Add(s);
            //}
            //context.SaveChanges();

           
        }
    }
}


