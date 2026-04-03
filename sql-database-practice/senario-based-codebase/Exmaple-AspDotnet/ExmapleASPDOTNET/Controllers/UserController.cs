using ExmapleASPDOTNET.Data;
using ExmapleASPDOTNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExmapleASPDOTNET.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // CREATE (no Id accepted from client)
    [HttpPost]
    public async Task<ActionResult<User>> Create(CreateUserDto dto)
    {
        var user = new User
        {
            Name = dto.Name,
            Email = dto.Email
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }

    // READ ALL
    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAll()
    {
        var users = await _context.Users.AsNoTracking().ToListAsync();
        return Ok(users);
    }

    // READ BY ID
    [HttpGet("{id:int}")]
    public async Task<ActionResult<User>> GetById(int id)
    {
        var user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return user is null ? NotFound() : Ok(user);
    }

    // UPDATE
    [HttpPut("{id:int}")]
    public async Task<ActionResult<User>> Update(int id, CreateUserDto dto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user is null) return NotFound();

        user.Name = dto.Name;
        user.Email = dto.Email;

        await _context.SaveChangesAsync();
        return Ok(user);
    }

    // DELETE
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user is null) return NotFound();

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
