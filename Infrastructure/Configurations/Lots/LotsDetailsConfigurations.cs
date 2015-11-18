using System.Data.Entity.ModelConfiguration;

namespace Infrastructure.Configurations.Lots
{
    public class LotsDetailsConfigurations: EntityTypeConfiguration<DomainModels.Lots.LotDetailsModel>
    {
        public LotsDetailsConfigurations()
        {
            //Primary key
            HasKey(key => key.Id);

            //Table & columns relationship
            //Many to many
            HasMany(ld => ld.CategoryId)
                .WithMany(ctg => ctg.LotDetailsId);

            //One to many
            HasOptional(ld => ld.GuaranteeId)
                .WithMany(g => g.LotDetailsId);

            //Required one to many/one
            HasOptional(ld => ld.ApplicationUserId)
                .WithOptionalDependent(u => u.LotDetailsId);
            HasOptional(ld => ld.LotId)
                .WithOptionalDependent(l => l.LotDetailsId);
        }
    }
}
