using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            Diseasexcitizens = new HashSet<Diseasexcitizen>();
        }

        public int Dui { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? EssentialJob { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Diseasexcitizen> Diseasexcitizens { get; set; }
    }
}
