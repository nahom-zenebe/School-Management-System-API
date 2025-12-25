
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyApi.DTOs.Student;
using MyApi.Models;
using MyApi.Repositories.Interfaces;


[ApiController]
[Route("api/auth")]

public class AuthController : ControllerBase{
    private readonly AppDbContext _context;
    private readonly JwtService _jwtService;


    public AuthController( AppDbContext context, JwtService jwtService){
        context=_context
        jwtService=_jwtService

    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        if (_context.Users.Any(u => u.Email == dto.Email))
            return BadRequest("Email already exists");

        var user = new User
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Role = dto.Role,
            PasswordHash = PasswordHasherHelper.Hash(dto.Password)
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok("User registered");
    }

    [HttpPost("login")]
    public async Task<IActionResult>Login(LoginDto dto){
       var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == dto.Email);

      if (user == null ||
            !PasswordHasherHelper.Verify(user.PasswordHash, dto.Password))
            return Unauthorized("Invalid credentials");


     var token = _jwtService.GenerateToken(user);

        return Ok(new { token });

    }



}