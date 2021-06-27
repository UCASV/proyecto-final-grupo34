using System;
using System.Collections.Generic;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public int BoothId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LogIn { get; set; }
        public DateTime LogOut { get; set; }

        public virtual Booth Booth { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
