namespace HyperCompanyCase.Business.Abstract.Command
{
    public interface IDynamicCommandRepository
    {
        Task<int> AddAsync<T>(T entity);
        Task<int> UpdateAsync<T>(T entity);
        Task<int> HardDeleteAsync<T>(int id);
    }
}
