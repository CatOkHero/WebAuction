using System;
using System.Threading.Tasks;
using DomainModels.ApplicationSecurity;
using DomainModels.Users;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Infrastructure.Repository
{
    public class AuctionDbRepository: IDisposable
    {
        private readonly AuctionDb.AuctionDb _auctionDb;
        private readonly ApplicationUserManager _applicationUserManager;

        public AuctionDbRepository()
        {
            _auctionDb = AuctionDb.AuctionDb.Create();
            _applicationUserManager = new ApplicationUserManager(new UserStore<ApplicationUser>());
        }
        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = userModel.Name
            };

            return await _applicationUserManager.CreateAsync(user, userModel.Password);
        }

        public async Task<ApplicationUser> FindUser(string userName, string password)
        {
            return await _applicationUserManager.FindAsync(userName, password);
        }
        public void Dispose()
        {
            _auctionDb.Dispose();
            _applicationUserManager.Dispose();
        }
    }
}