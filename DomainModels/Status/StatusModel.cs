using System;
using System.Collections.Generic;
using DomainModels.Lots;

namespace DomainModels.Status
{
    public class StatusModel
    {
        public StatusModel()
        {
            LotId = new List<LotModel>();
        }

        public Guid Id { get; set; }
        public String Status { get; set; }
        public virtual ICollection<LotModel> LotId { get; set; } 
    }
}
