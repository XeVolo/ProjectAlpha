using Auth.DTOs;
using Auth.Interfaces;
using Infrastructure.PasswordHasher;
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
    private readonly IUnitOfWork _unitofwork;
    private readonly IPasswordHasher _hasher;
    private readonly ITokenService _tokenService;

    public AuthService(IUnitOfWork unitOfWork, IPasswordHasher hasher, ITokenService tokenService)
    {
        _unitofwork = unitOfWork;
        _hasher = hasher;
        _tokenService = tokenService;
    }

    public async Task<bool> RegisterAsync(RegisterRequestDto dto)
    {
        if (await _unitofwork.Users.ExistsByEmailAsync(dto.Email))
            throw new Exception("User already exists");

        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PasswordHash = _hasher.Hash(dto.Password),
        };

        await _unitofwork.Users.AddAsync(user);
        await _unitofwork.SaveChangesAsync();
        return true;
    }

    public async Task<LoginResultDto> LoginAsync(LoginRequestDto dto)
    {
        var user = await _unitofwork.Users.GetByEmailAsync(dto.Email);
        if (user == null || !_hasher.Verify(dto.Password, user.PasswordHash))
            throw new Exception("Invalid credentials");

        var tokens = _tokenService.GenerateTokens(user);

        user.RefreshToken = tokens.RefreshToken;
        user.RefreshTokenExpires = tokens.RefreshTokenExpires;

        await _unitofwork.Users.Update(user);
        await _unitofwork.SaveChangesAsync();

        return new LoginResultDto
        {
            AccessToken = tokens.AccessToken,
            RefreshToken = tokens.RefreshToken,
        };
    }
}

