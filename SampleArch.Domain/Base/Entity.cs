﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Domain.Base
{
    public abstract class BaseEntity
    {

    }

    public abstract class Entity : BaseEntity, IEntity
    {
        public virtual int Id { get; set; }
    }
}
