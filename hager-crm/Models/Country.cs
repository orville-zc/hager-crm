﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hager_crm.Models
{
    public class Country
    {
        public Country()
        {
            Companies = new HashSet<Company>();
            Employees = new HashSet<Employee>();
        }
        public int CountryID { get; set; }
        [Display(Name = "Country")]
        [StringLength(40, ErrorMessage = "Please enter a Country with less than 40 characters")]
        public string CountryName { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
