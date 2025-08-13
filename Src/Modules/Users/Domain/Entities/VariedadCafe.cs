using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColombianCoffee.Src.Modules.Users.Domain.Entities
{
    public class VariedadCafe
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Porte { get; set; } = "";
        public string TamanoGrano { get; set; } = "";
        public string AltitudOptima { get; set; } = "";
        public string ResistenciaRoya { get; set; } = "";
    }
}