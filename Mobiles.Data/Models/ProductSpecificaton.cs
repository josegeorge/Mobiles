using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class ProductSpecificaton
    {
        public int Id { get; set; }
        public Nullable<int> HeadingValue_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual SpecifictionHeadingValue SpecifictionHeadingValue { get; set; }
    }
}
