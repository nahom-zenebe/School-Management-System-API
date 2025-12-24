


public interface IClassRepository{
    Task<IEnumerable<Class>>GetAllClass();
    Task<Class>GetClassById();
    Task AddAsync(Class class);
    Task UpdateAsync(int id,Class class);
    Task DeleteAsync(int id);
}