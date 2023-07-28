namespace LeaveManagement.web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(int id);

        Task DeleteAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<bool> Exist(int id);

        Task UpdateAsync(T entity);

        Task<T> AddAsync(T entity);

        Task AddRangeAsync(List<T> entities);

        Task<T?> GetAsync(int? id);
    }
}
