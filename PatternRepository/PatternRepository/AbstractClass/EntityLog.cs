using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityLog : EntityPattern
    {
        public abstract int StatusId {  get; set; }
    }
}
