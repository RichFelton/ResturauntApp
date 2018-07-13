using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturauntApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyNumber { get; set; }
        public DateTime DateStarted { get; set; }
    }
}