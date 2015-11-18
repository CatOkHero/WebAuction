﻿using System;
using System.Collections.Generic;
using DomainModels.ApplicationSecurity;
using DomainModels.Categories;
using DomainModels.Guarantee;

namespace DomainModels.Lots
{
    public class LotDetailsModel
    {
        public LotDetailsModel()
        {
            //UserId = new List<ApplicationUser>();
            //LotId = new List<LotModel>();
            CategoryId = new List<CategoryModel>();
        }

        public Guid Id { get; set; }
        public Double Price { get; set; }
        public String Adress { get; set; }
        public String Description { get; set; }
        public Int16 Quantity { get; set; }
        //public virtual ICollection<ApplicationUser> UserId { get; set; }
        public virtual ApplicationUser ApplicationUserId { get; set; }
        public virtual GuaranteeModel GuaranteeId { get; set; }
        public virtual LotModel LotId { get; set; }
        //public virtual ICollection<LotModel> LotId { get; set; }
        public virtual ICollection<CategoryModel> CategoryId { get; set; }
    }
}
