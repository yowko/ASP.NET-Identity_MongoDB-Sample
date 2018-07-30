using AspNet.Identity.MongoDB;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityMongo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}