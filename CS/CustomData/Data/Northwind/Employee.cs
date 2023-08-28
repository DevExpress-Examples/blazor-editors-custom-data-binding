﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomData.Data.Northwind {
    public partial class Employee {
        public int EmployeeId { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Required]
        [Range(typeof(DateTime), "1/1/2000", "1/1/2020",
        ErrorMessage = "HireDate must be between {1:d} and {2:d}")]
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public string Text => $"{FirstName} {LastName} ({Title})";
        public string ImageFileName => $"Employees/{EmployeeId}.jpg";
    }
}
