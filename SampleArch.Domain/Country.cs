using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleArch.Domain.Base;

namespace SampleArch.Domain
{
    public class Country : Entity
    {
        public virtual string Name { get; set; }

        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
