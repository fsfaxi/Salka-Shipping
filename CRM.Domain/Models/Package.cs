using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRM.Domain.Models
{
    public class Package
    {
        [Key]
        public int Id { set; get; }
        public string pkg_location { set; get; }
        public string pkg_content_description { set; get; }
        public int pkg_tracking_number { set; get; }
        public int CustomerID { set; get; } // FK

        public Customer Customer { set; get; } // Navigation Property 

        //Value Contructor 
        public Package (int costumer_id ,string p_location, string p_content_description,int p_tracking_number)
        {
            CustomerID = costumer_id;
            pkg_location = p_location;
            pkg_content_description = p_content_description;
            pkg_tracking_number = p_tracking_number;

        }    

    }
}
