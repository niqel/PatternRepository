using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityCatalog : EntityPatternUpdate
    {
        public abstract bool Active { get; set; }
        public abstract string Code {  get; set; }  
        public abstract string Name {  get; set; }  
        public abstract string Description {  get; set; }   
    }
}
