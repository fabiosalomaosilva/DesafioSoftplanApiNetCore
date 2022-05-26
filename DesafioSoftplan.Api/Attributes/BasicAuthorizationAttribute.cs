using Microsoft.AspNetCore.Authorization;

namespace DesafioSoftplan.Api.Attributes
{
    public class BasicAuthorizationAttribute : AuthorizeAttribute
    {
        public BasicAuthorizationAttribute()
        {
            Policy = "BasicAuthentication";
        }
    }
}
