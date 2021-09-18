using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityPattern
    {
        public abstract int CreatedBy {  get; set; }
        public abstract DateTime CreatedAt {  get; set; }
    }
}
