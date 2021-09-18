using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityLog : EntityPattern
    {
        public abstract int ForeignId {  get; set; }
        public abstract int StatusId {  get; set; }
        public virtual EntityOperation EntityOperation { get; set; }
    }
}
