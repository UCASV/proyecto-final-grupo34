using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Diseasexcitizen
    {
        public int Id { get; set; }
        public int DiseaseId { get; set; }
        public int CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
