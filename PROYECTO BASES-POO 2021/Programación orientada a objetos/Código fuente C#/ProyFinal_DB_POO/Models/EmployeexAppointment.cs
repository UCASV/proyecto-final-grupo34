using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Employeexappointment
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? AppointmentId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
