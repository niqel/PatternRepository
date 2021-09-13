using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityPatternUpdate : EntityPattern
    {
        public int UpdatedBy {  get; set; }
        public DateTime UpdatedAt { get; set; } 
    }
}
