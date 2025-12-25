using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Schoolmanagmentsystem.DTOs.Student;
using Schoolmanagmentsystem.model;
using Schoolmanagmentsystem.Repositories.Interfaces;

namespace Schoolmanagmentsystem.Controllers;



[ApiController]
[Route("/api/student")]
public class StudentsController : ControllerBase{

    private readonly IStudentRepositoryImpl _repo
    private readonly IMapper _mapper;


    public StudentsController(IStudentRepositoryImpl _repo,IMapper _mapper){
        _repo=repo;
        _context=context;

    }

    [HttpGet("/getallstudent")]
    public async Task<IEnumerable<Student>>GetAllStudent(){
        var allStudent=await _repo.GetAllStudent();
        return Ok(_mapper.Map<IEnumerable<ResponseStudentDto>>(students))
    }

    [HttpGet("/getallstudent/{id}")]
    public async Task<Student>GetStudentById(int id ){
          var student = await _repo.GetByIdAsync(id);
        if (student == null) return NotFound();

        return Ok(_mapper.Map<ResponseStudentDto>(student));
    }
  
    [HttpPost("/createstudent")]
    public async Task<IActionResult>createstudent(CreateStudentDto dto){

        var student = _mapper.Map<Student>(dto);
         await _repo.AddAsync(student);
        await _repo.SaveAsync();

          return CreatedAtAction(nameof(GetById), new { id = student.Id },
            _mapper.Map<StudentDto>(student));

    }

     [HttpPut("/updatestudent/{id}")]
    public async Task<IActionResult> Update(int id, UpdateStudentDto dto)
    {
        var student = await _repo.GetByIdAsync(id);
        if (student == null) return NotFound();

        _mapper.Map(dto, student);
        _repo.Update(student);
        await _repo.SaveAsync();

        return NoContent();
    }

 [HttpDelete("/deletestudent/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var student = await _repo.GetByIdAsync(id);
        if (student == null) return NotFound();

        _repo.Delete(student);
        await _repo.SaveAsync();

        return NoContent();
    }
}