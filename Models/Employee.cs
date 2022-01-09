using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudapi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string position { get; set; }
        public decimal Salary { get; set; }
    }
}
