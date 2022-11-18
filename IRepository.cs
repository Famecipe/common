namespace Famecipe.Common
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> Get();
        public Task<T> Get(string identifer);
        public Task<T> Create(T obj);
        public Task Update(string identifer, T obj);
        public Task Delete(string identifer);
    }
}