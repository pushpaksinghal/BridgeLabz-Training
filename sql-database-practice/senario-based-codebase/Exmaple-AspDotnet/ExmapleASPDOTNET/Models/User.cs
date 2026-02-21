using System;

namespace ExmapleASPDOTNET.Models;
public class User
{
    public int Id { get; set; }                 // IDENTITY in DB
    public required string Name { get; set; }
    public required string Email { get; set; }
}