


public interface IAnnouncmentRepository{
    Task<IEnumerable<Announcment>>GetAllAnnouncment();
    Task<Announcment>GetAnnouncmentById();
    Task AddAsync(Announcment announcment);
    Task UpdateAsync(int id,Announcment announcment);
    Task DeleteAsync(int id);
}