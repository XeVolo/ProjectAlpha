using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;

public class User
{
    public Guid         Id                  { get; set; }
    public string       Email               { get; set; } = string.Empty;
    public string       PasswordHash        { get; set; } = string.Empty;
    public bool         IsActive            { get; set; } = true;
    public DateTime     RegisteredAt        { get; set; } = DateTime.UtcNow;
    public string?      RefreshToken        { get; set; }
    public DateTime?    RefreshTokenExpires { get; set; }
    public string       FirstName           { get; set; } = string.Empty;
    public string       LastName            { get; set; } = string.Empty;
    public DateTime?    DateOfBirth         { get; set; }
    public Guid         RoleId              { get; set; }
    public Role         Role                { get; set; } = null!;

}
