public interface IStudentRepository{
    Task<IEnumerable<Student>>GetAllStudent();
    Task<Student>GetStudentById();
    Task AddAsync(Student student);
    Task UpdateAsync(int id,Student student);
    Task DeleteAsync(int id);
}