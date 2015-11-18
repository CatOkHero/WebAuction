﻿using System.Data.Entity.ModelConfiguration;
using DomainModels.ApplicationSecurity;

namespace Infrastructure.Configurations.Users
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            //Relationship many to one
            HasMany(u => u.BetId)
                .WithOptional(b => b.UserId);
            HasMany(u => u.PhotoId)
                .WithOptional(p => p.UserId);
            HasOptional(u => u.LotDetailsId)
                .WithOptionalPrincipal(ld => ld.ApplicationUserId);
        }
    }
}
