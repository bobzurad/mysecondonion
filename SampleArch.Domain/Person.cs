using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleArch.Domain.Base;

namespace SampleArch.Domain
{
    public class Person : AuditableEntity
    {
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual string State { get; set; }
        public virtual int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
