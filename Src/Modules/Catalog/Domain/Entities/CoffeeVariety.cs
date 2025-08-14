namespace ColombianCoffee.Src.Modules.Catalog.Domain.Entities
{
    // Representa una variedad de café en el sistema
    public class CoffeeVariety
    {
        // Identificador único
        public int Id { get; set; }

        // Nombre común y científico
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }

        // Ruta o nombre del archivo de imagen
        public string Imagen { get; set; }

        // Descripción general
        public string Descripcion { get; set; }

        // Atributos agronómicos
        public string Porte { get; set; } // Alto o Bajo
        public string TamanoGrano { get; set; } // Pequeño, Medio, Grande
        public int AltitudOptima { get; set; }
        public string PotencialRendimiento { get; set; }
        public string CalidadSegunAltitud { get; set; }

        // Resistencias
        public string ResistenciaRoya { get; set; }
        public string ResistenciaAntracnosis { get; set; }
        public string ResistenciaNematodos { get; set; }

        // Información complementaria
        public string TiempoCosecha { get; set; }
        public string Maduracion { get; set; }
        public string Nutricion { get; set; }
        public string DensidadSiembra { get; set; }

        // Historia y linaje genético
        public string Historia { get; set; }
        public string LinajeGenetico { get; set; }
    }
}
