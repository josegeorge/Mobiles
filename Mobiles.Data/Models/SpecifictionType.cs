using System;
using System.Collections.Generic;

namespace Mobiles.Data.Models
{
    public partial class SpecifictionType
    {
        public SpecifictionType()
        {
            this.SpecifictionHeadings = new List<SpecifictionHeading>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SpecifictionHeading> SpecifictionHeadings { get; set; }
    }
}
