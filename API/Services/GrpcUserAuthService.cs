using API.UserAuth;
using Auth.DTOs;
using Auth.Interfaces;
using Auth.Services;
using Grpc.Core;
using Microsoft.AspNetCore.Identity;

public class GrpcUserAuthService(IAuthService authService) : UserAuthService.UserAuthServiceBase
{
    public override async Task<LoginResponse> Login(LoginRequest request, ServerCallContext context)
    {
        try
        {
            var result = await authService.LoginAsync(new LoginRequestDto
            {
                Email = request.Email,
                Password = request.Password
            });

            return new LoginResponse
            {
                AccessToken = result.AccessToken,
            };
        }
        catch (UnauthorizedAccessException)
        {
            throw new RpcException(new Status(StatusCode.Unauthenticated, "Invalid credentials"));
        }
    }

}
