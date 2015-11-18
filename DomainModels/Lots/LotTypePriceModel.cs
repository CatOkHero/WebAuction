using System;
using System.Collections.Generic;

namespace DomainModels.Lots
{
    public class LotTypePriceModel
    {
        public LotTypePriceModel()
        {
            LotId = new List<LotModel>();
        }

        public Guid Id { get; set; }
        public String TypePrice { get; set; }
        public virtual ICollection<LotModel> LotId { get; set; }
    }
}