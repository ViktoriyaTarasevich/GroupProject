using FileExchange.Domain.Abstract;
using FileExchange.Domain.Entities.Identity;
using FileExchange.Domain.Enums;

using Microsoft.AspNet.Identity.EntityFramework;


namespace FileExchange.Domain.Entities
{
    public class UserDomain : IdentityUser<int, UserLoginDomain, UserRoleDomain, UserClaimDomain>, IIntBaseEntity
    {
        public string Nickname { get; set; }

        public UserStatus Status { get; set; }

        public UserRestrictionsConfigDomain RestrictionsConfig { get; set; }
    }
}