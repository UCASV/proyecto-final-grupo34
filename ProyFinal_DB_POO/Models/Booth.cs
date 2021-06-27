using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Booth
    {
        public Booth()
        {
            Employees = new HashSet<Employee>();
            Logs = new HashSet<Log>();
        }

        public int BoothId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int EmployeeInChargeId { get; set; }

        public virtual Employee EmployeeInCharge { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
