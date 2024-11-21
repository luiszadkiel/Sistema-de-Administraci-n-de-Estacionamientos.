namespace p2_FINAAL_parqueo
{
    public interface IRepository
    {
        List<T> GetAll(); //buscar todos
        T GetById(int id); // buscar especifico
        void Set(T entidad); // setear
        void Update(T entidad);  // actualizar
        void Delete(int id);   // borrar
    }
}
