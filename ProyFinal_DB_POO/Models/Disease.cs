using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Disease
    {
        public Disease()
        {
            Diseasexcitizens = new HashSet<Diseasexcitizen>();
        }

        public int DiseaseId { get; set; }
        public string Disease1 { get; set; }

        public virtual ICollection<Diseasexcitizen> Diseasexcitizens { get; set; }
    }
}
