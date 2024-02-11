using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_App2.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Departement { get; set; }
    }
}