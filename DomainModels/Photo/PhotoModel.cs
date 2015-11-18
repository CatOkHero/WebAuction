using System;
using DomainModels.ApplicationSecurity;
using DomainModels.Lots;

namespace DomainModels.Photo
{
    public class PhotoModel
    {
        public Guid Id { get; set; }
        public String Photot { get; set; }
        public LotModel LotId { get; set; }
        public ApplicationUser UserId { get; set; }
    }
}
