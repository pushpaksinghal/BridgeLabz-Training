using System;
using Microsoft.EntityFrameworkCore;
using ExmapleASPDOTNET.Models;

namespace ExmapleASPDOTNET.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    
    public DbSet<User> Users => Set<User>();
}

