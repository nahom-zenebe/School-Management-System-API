
namespace Schoolmanagmentsystem DTOs.StudentDtos;

public class CreateStudentDto{
    public int UserId { get; set; }
    public string StudentCode { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int ClassId { get; set; }

}

public class ResponseStudentDto{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string StudentCode { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int ClassId { get; set; }
    public int TotalAttendance { get; set; }
}