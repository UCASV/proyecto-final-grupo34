using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentxSideEffects = new HashSet<AppointmentxSideEffect>();
            Employeexappointments = new HashSet<Employeexappointment>();
        }

        public int AppointmentId { get; set; }
        public DateTime DateTime { get; set; }
        public int CenterId { get; set; }
        public int Dui { get; set; }
        public DateTime QueueStart { get; set; }
        public DateTime VaccinationTime { get; set; }

        public virtual VaccinationCenter Center { get; set; }
        public virtual Citizen DuiNavigation { get; set; }
        public virtual ICollection<AppointmentxSideEffect> AppointmentxSideEffects { get; set; }
        public virtual ICollection<Employeexappointment> Employeexappointments { get; set; }
    }
}
