using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Infrastructure.Identity;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid? UserId => GetGuidClaim("sub"); 
    public Guid? AdminId => GetGuidClaim("adminId"); 

    private Guid? GetGuidClaim(string claimType)
    {
        var claimValue = _httpContextAccessor.HttpContext?.User?.FindFirst(claimType);
        return Guid.TryParse(claimValue?.Value, out var guid) ? guid : null;
    }
}
