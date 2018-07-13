using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResturauntApp.Models
{
    public class Addresses
    {
        [Key]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        [ForeignKey("Customers")]
        public int CustomerID { get; set; }
        public virtual Customers Customers { get; set; }
    }
}