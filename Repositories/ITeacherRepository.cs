


public interface ITeacherRepository{
    Task<IEnumerable<Teacher>>GetAllTeacher();
    Task<Teacher>GetTeacherById();
    Task AddAsync(Teacher teacher);
    Task UpdateAsync(int id,Teacher teacher);
    Task DeleteAsync(int id);
}