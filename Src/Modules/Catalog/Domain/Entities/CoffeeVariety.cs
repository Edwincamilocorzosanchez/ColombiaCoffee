namespace ColombianCoffee.Src.Modules.Catalog.Domain.Entities
{
    public class CoffeeVariety
    {
        public int Id { get; set; }
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Porte { get; set; } // Alto o Bajo
        public string TamanoGrano { get; set; } // Pequeño, Medio, Grande
        public int AltitudOptima { get; set; }
        public string PotencialRendimiento { get; set; }
        public string CalidadSegunAltitud { get; set; }
        public string ResistenciaRoya { get; set; }
        public string ResistenciaAntracnosis { get; set; }
        public string ResistenciaNematodos { get; set; }
        public string TiempoCosecha { get; set; }
        public string Maduracion { get; set; }
        public string Nutricion { get; set; }
        public string DensidadSiembra { get; set; }
        public string Historia { get; set; }
        public string LinajeGenetico { get; set; }
    }
}
