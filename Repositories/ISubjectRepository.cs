


public interface ISubjectRepository{
    Task<IEnumerable<Subject>>GetAllSubject();
    Task<Subject>GetSubjectById();
    Task AddAsync(Subject subject);
    Task UpdateAsync(int id,Subject subject);
    Task DeleteAsync(int id);
}