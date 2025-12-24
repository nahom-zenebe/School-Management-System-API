public interface IGradeRepository{
    Task<IEnumerable<Grade>>GetAllGrade();
    Task<Grade>GetGradeById();
    Task AddAsync(Grade grade);
    Task UpdateAsync(int id,Grade grade);
    Task DeleteAsync(int id);
}