
using DesafioSoftplan.Services.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DesafioSoftplan.Api.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<UserDto> WithoutPasswords(this IEnumerable<UserDto> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static UserDto WithoutPassword(this UserDto user)
        {
            user.Password = null;
            return user;
        }
    }
}
