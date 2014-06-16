using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class Brand
    {
        public Brand()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfProducts { get; set; }
        public bool HasToBeMonitered { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
