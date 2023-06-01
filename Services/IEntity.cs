namespace Lab5.Services
{
    public interface IEntity<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public T Add(T tobj);
        public T Update(T tobj);
        public void DeleteById(int id);
    }
}
