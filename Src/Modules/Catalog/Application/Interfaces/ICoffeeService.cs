using System.Collections.Generic;
using ColombianCoffee.Src.Modules.Catalog.Domain.Entities;

namespace ColombianCoffee.Src.Modules.Catalog.Application.Interfaces
{
    // Define la lógica de negocio para manejar variedades de café
    public interface ICoffeeService
    {
        // Listar todas las variedades
        IEnumerable<CoffeeVariety> GetAll();

        // Buscar una variedad por ID
        CoffeeVariety GetById(int id);

        // Obtener variedades filtradas según criterios
        IEnumerable<CoffeeVariety> GetFiltered(string porte, string tamano, int? altitud, string resistencia);

        // Crear nueva variedad
        void Create(CoffeeVariety variety);

        // Editar una variedad existente
        void Edit(CoffeeVariety variety);

        // Eliminar una variedad
        void Remove(int id);
    }
}
