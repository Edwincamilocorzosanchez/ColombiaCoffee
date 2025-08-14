using System.Collections.Generic;
using ColombianCoffee.Src.Modules.Catalog.Domain.Entities;

namespace ColombianCoffee.Src.Modules.Catalog.Application.Interfaces
{
    // Define el contrato para acceder a los datos de CoffeeVariety
    public interface ICoffeeRepository
    {
        // Obtener todas las variedades
        IEnumerable<CoffeeVariety> GetAll();

        // Buscar una variedad por su ID
        CoffeeVariety GetById(int id);

        // Filtrar variedades por criterios
        IEnumerable<CoffeeVariety> Filter(string porte, string tamano, int? altitud, string resistencia);

        // Crear nueva variedad
        void Add(CoffeeVariety variety);

        // Actualizar una variedad existente
        void Update(CoffeeVariety variety);

        // Eliminar una variedad por ID
        void Delete(int id);
    }
}
