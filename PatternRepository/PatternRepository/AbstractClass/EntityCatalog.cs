using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityCatalog : EntityRelation
    {
        public abstract string Code {  get; set; }  
        public abstract string Name {  get; set; }  
        public string Description {  get; set; }   
    }
}
