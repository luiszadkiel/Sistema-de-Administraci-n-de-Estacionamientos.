using Administración_Estacionamientos_.capa_datos.Context;
using Microsoft.EntityFrameworkCore;
using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_negocio;

namespace Administración_Estacionamientos_.capa_negocio.Services
{
    public class RepositoryServices<T> : IRepository<T> where T : class
    {
        private readonly configuracionBD_Context contexto;
        DbSet<T> dbSet;

        public RepositoryServices(configuracionBD_Context contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }

     
        public void Delete(int id)
        {
            var entidad = GetById(id);
            dbSet.Remove(entidad);
            contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Set(T entidad)
        {
            dbSet.Add(entidad);
            contexto.SaveChanges();
        }


        public void Update(T entidad)
        {
            dbSet.Attach(entidad);
            contexto.Entry(entidad).State = EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
