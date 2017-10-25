using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagment.Domain.Models
{
    public class PackageItem 
    {
        private long pkg_id { set; get; }
        public string pkg_location { set; get; }
        public string pkg_payer { set; get; }
        public string payer { set; get; }
        public string payer_account_number { set; get; }
        public float pkg_weight { set; get; }
        public float pkg_height { set; get; }
        public float pkg_width { set; get; }
        public string pkg_content_description { set; get; }

        public string sender_first_name { set; get; }
        public string sender_middle_name { set; get; }
        public string sender_last_name { set; get; }
        public string sender_address { set; get; }
        public string sender_city { set; get; }
        public string sender_country { set; get; }
        public string sender_phone { set; get; }
        public string sender_postcode { set; get; }
        public string sender_account_number { set; get; }

        public string receiver_first_name { set; get; }
        public string receiver_middle_name { set; get; }
        public string receiver_last_name { set; get; }
        public string receiver_address { set; get; }
        public string receiver_city { set; get; }
        public string receiver_country { set; get; }
        public string receiver_phone { set; get; }
        public string receiver_postcode { set; get; }

    }
}
