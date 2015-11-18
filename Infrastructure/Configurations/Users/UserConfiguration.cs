using System.Data.Entity.ModelConfiguration;
using DomainModels.Users;

namespace Infrastructure.Configurations.Users
{
    //public class UserConfiguration: EntityTypeConfiguration<UserModel>
    //{
    //    public UserConfiguration()
    //    {
    //        //Primary key
    //        HasKey(key => key.Id);


    //        //Relationship many to one
    //        HasMany(u => u.BetId)
    //            .WithOptional(b => b.UserId);
    //        HasMany(u => u.PhotoId)
    //            .WithOptional(p => p.UserId);
    //        HasMany(u => u.LotDetailId)
    //            .WithMany(ld => ld.UserId);

    //        //Relationship one to one
    //        //HasOptional(u => u.BannedUserId)
    //        //    .WithOptionalPrincipal(bu => bu.UserId);
    //    }
    //}

    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationSecurity.ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
           

            //Relationship many to one
            HasMany(u => u.BetId)
                .WithOptional(b => b.UserId);
            HasMany(u => u.PhotoId)
                .WithOptional(p => p.UserId);
            HasMany(u => u.LotDetailId)
                .WithMany(ld => ld.UserId);

            //Relationship one to one
            //HasOptional(u => u.BannedUserId)
            //    .WithOptionalPrincipal(bu => bu.UserId);
        }
    }
}
