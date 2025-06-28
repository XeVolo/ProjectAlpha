using Auth.Token;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Interfaces;
public interface ITokenService
{
    TokenResult GenerateTokens(User user);
    ClaimsPrincipal? ValidateAccessToken(string token);
    ClaimsPrincipal? GetPrincipalFromToken(string token);
}

