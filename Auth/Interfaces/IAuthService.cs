using Auth.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Interfaces;
public interface IAuthService
{
    Task<bool> RegisterAsync(RegisterRequestDto dto);
    Task<LoginResultDto> LoginAsync(LoginRequestDto dto);
}
