using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class AppointmentxSideEffect
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int EffectId { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual SideEffect Effect { get; set; }
    }
}
