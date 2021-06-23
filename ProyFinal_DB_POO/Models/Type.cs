using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Type
    {
        public Type()
        {
            Employees = new HashSet<Employee>();
        }

        public int TypeId { get; set; }
        public string Type1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
