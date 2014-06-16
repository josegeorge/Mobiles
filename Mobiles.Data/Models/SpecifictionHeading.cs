using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class SpecifictionHeading
    {
        public SpecifictionHeading()
        {
            this.SpecifictionHeadingValues = new List<SpecifictionHeadingValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Type_Id { get; set; }
        public virtual SpecifictionType SpecifictionType { get; set; }
        public virtual ICollection<SpecifictionHeadingValue> SpecifictionHeadingValues { get; set; }
    }
}
