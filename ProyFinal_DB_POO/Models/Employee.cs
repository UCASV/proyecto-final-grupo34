using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Booths = new HashSet<Booth>();
            Employeexappointments = new HashSet<Employeexappointment>();
            Logs = new HashSet<Log>();
        }

        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int TypeId { get; set; }
        public int? BoothId { get; set; }

        public virtual Booth Booth { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Booth> Booths { get; set; }
        public virtual ICollection<Employeexappointment> Employeexappointments { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
