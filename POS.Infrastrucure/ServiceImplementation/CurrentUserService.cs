using Microsoft.AspNetCore.Http;
using POS.Application.Common;
using POS.Application.Common.Interface;

namespace POS.Infrastrucure.ServiceImplementation
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string UserId =>_httpContextAccessor.HttpContext.User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value
            ??throw new UnAuthorized("User not found.");
    }
}
