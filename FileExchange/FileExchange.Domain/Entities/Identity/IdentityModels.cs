using Microsoft.AspNet.Identity.EntityFramework;

namespace FileExchange.Domain.Entities.Identity
{
    public class UserLoginDomain : IdentityUserLogin<int>
    {

    }

    public class UserRoleDomain : IdentityUserRole<int>
    {

    }

    public class UserClaimDomain : IdentityUserClaim<int>
    {

    }

    public class RoleDomain : IdentityRole<int, UserRoleDomain>
    {
        public RoleDomain()
        {

        }

        public RoleDomain(string roleName)
        {
            Name = roleName;
        }
    }
}