using Microsoft.EntityFrameworkCore;

namespace Administración_Estacionamientos.capa_negocio.interfaz
{
    public interface IRepository<T>
    {
        List<T> GetAll(); // Obtener todos
        T GetById(int id); // Obtener uno por ID
        void Set(T entidad); // Insertar
        void Update(T entidad);  // Actualizar
        void Delete(int id);   // Eliminar
    }
}
