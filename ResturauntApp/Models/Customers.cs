using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturauntApp.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string FavoriteMeal { get; set; }
        public string FavoriteDrink { get; set; }
        public double LargestBill { get; set; }

        public virtual ICollection<Addresses> Address { get; set; }
    }
}