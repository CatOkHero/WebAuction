using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace Infrastructure.ApplicationSecurity
{
    public class ApplicationUserManager : UserManager<Infrastructure.ApplicationSecurity.ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<Infrastructure.ApplicationSecurity.ApplicationUser> store)
            : base(store)
        {
        }

        public static ApplicationUserManager CreareUserManager(IdentityFactoryOptions<ApplicationUserManager> applicationOptions, IOwinContext owinContext)
        {
            var manager = new ApplicationUserManager(new UserStore<Infrastructure.ApplicationSecurity.ApplicationUser>(owinContext.Get<AuctionDb.AuctionDb>()));
            // Configure validation logic for user names
            manager.UserValidator = new UserValidator<Infrastructure.ApplicationSecurity.ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true
            };

            //manager.EmailService = new EmailService();
            var dataProtectionProvider = applicationOptions.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<Infrastructure.ApplicationSecurity.ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"))
                {
                    TokenLifespan = TimeSpan.FromHours(6)
                };
            }

            return manager;
        }
    }
}