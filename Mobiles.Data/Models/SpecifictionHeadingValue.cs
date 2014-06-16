using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class SpecifictionHeadingValue
    {
        public SpecifictionHeadingValue()
        {
            this.ProductSpecificatons = new List<ProductSpecificaton>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public Nullable<int> Heading_Id { get; set; }
        public virtual ICollection<ProductSpecificaton> ProductSpecificatons { get; set; }
        public virtual SpecifictionHeading SpecifictionHeading { get; set; }
    }
}
