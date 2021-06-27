using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class VaccinationCenter
    {
        public VaccinationCenter()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int CenterId { get; set; }
        public string VaccinationCenter1 { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
