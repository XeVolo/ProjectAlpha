using Auth.DTOs;
using Auth.Interfaces;
using Models.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Services;
public class AuthService : IAuthService
{
    private readonly IUserRepository _users;
    private readonly IPasswordHasher _hasher;
    private readonly ITokenService _tokenService;

    public AuthService(IUserRepository users, IPasswordHasher hasher, ITokenService tokenService)
    {
        _users = users;
        _hasher = hasher;
        _tokenService = tokenService;
    }

    public async Task RegisterAsync(RegisterRequest dto)
    {
        if (await _users.ExistsByEmailAsync(dto.Email))
            throw new Exception("User already exists");

        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PasswordHash = _hasher.Hash(dto.Password),
        };

        await _users.AddAsync(user);
    }

    public async Task<AuthResult> LoginAsync(LoginRequest dto)
    {
        var user = await _users.GetByEmailAsync(dto.Email);
        if (user == null || !_hasher.Verify(dto.Password, user.PasswordHash))
            throw new Exception("Invalid credentials");

        var tokens = _tokenService.GenerateTokens(user);

        user.RefreshToken = tokens.RefreshToken;
        user.RefreshTokenExpires = tokens.RefreshTokenExpires;

        await _users.Update(user);

        return new AuthResult
        {
            AccessToken = tokens.AccessToken,
            RefreshToken = tokens.RefreshToken,
            Role = user.Role.Name
        };
    }
}

