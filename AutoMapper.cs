using AutoMapper;
using MyApi.DTOs.Student;
using MyApi.Models;


namespace MyApi.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Student, StudentDto>();
        CreateMap<CreateStudentDto, Student>();
        CreateMap<UpdateStudentDto, Student>();
    }
}
