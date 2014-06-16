using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            this.ProductSpecificatons = new List<ProductSpecificaton>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> Brand_Id { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<ProductSpecificaton> ProductSpecificatons { get; set; }
    }
}
