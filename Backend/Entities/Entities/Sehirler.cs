﻿using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public  class Sehirler : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual int ParentId { get; set; }
    }
}
