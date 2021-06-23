using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            AppointmentxSideEffects = new HashSet<AppointmentxSideEffect>();
        }

        public int EffectId { get; set; }
        public string SideEffect1 { get; set; }

        public virtual ICollection<AppointmentxSideEffect> AppointmentxSideEffects { get; set; }
    }
}
