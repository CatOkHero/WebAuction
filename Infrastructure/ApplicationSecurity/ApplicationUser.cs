using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DomainModels.Bets;
using DomainModels.Lots;
using DomainModels.Photo;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Infrastructure.ApplicationSecurity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            BetId = new List<BetModel>();
            PhotoId = new List<PhotoModel>();
            LotDetailId = new List<LotDetailsModel>();
        }

        public string Hometown { get; set; }

        public virtual ICollection<BetModel> BetId { get; set; }
        public virtual ICollection<PhotoModel> PhotoId { get; set; }
        public virtual ICollection<LotDetailsModel> LotDetailId { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            // Add custom user claims here
            return await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);;
        }
    }
}
