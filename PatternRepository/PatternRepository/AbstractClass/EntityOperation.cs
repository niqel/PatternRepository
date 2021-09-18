﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.AbstractClass
{
    public abstract class EntityOperation : EntityPatternUpdate
    {
        public abstract int StatusId {  get; set; }  

        public virtual ICollection<EntityLog> Logs {  get; set; }
    }
}
