


public interface IClassRepository{
    Task<IEnumerable<Attendance>>GetAllClass();
    Task<Attendance>GetClassById();
    Task AddAsync(Attendance attendance);
    Task UpdateAsync(int id,Attendance attendance);
    Task DeleteAsync(int id);
}