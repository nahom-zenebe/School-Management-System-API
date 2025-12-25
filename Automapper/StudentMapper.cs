using AutoMapper;
using Schoolmanagmentsystem.DTOs.StudentDtos;
using Schoolmanagmentsystem.model;


namespace MyApi.Mapping;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentDto>();
        CreateMap<CreateStudentDto, Student>();
        CreateMap<ResponseStudentDto, Student>();
        CreateMap<UpdateStudentDto, Student>();


    }
}
