
using MyApi.Data;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


public class IStudentRepositoryImpl:IStudentRepository{

    private readonly AppDbContext _context;

    public IStudentRepositoryImpl(AppDbContext context){
        context=_context;
    }

    public async task <IEnumerable<Student>> GetAllStudent()

}