using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityRelation : EntityPatternUpdate
    {
        public abstract bool Active {  get; set; }  
    }
}
