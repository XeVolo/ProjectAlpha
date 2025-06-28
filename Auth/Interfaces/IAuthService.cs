using Auth.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Interfaces;
public interface IAuthService
{
    Task RegisterAsync(RegisterRequest dto);
    Task<AuthResult> LoginAsync(LoginRequest dto);
}
