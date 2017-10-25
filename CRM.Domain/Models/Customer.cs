using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class Customer 
    {
        [Key]
        public int ID { set; get; }

        public string Customer_first_name { set; get; }
        public string Customer_middle_name { set; get; }
        public string Customer_last_name { set; get; }
        
        public ICollection<Package> Packages { set; get; }

        public void Add_Package (string pkg_location, string pkg_content_description, int pkg_tracking_number)
        {
            var pkg = new Package(this.ID, pkg_location, pkg_content_description, pkg_tracking_number);
            this.Packages.Add(pkg);

        }

    }
}
