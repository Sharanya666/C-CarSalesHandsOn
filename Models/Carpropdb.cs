using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesApplication.Models
{
    public class Carpropdb
    {
        public string CarModel { get; set; }
        public string CarName { get; set; }
        public string CarCategory { get; set; }
        public int CarPrice { get; set; }
        public int YearOfModel { get; set; }
        public string CarDescription { get; set; }
       
    }
}