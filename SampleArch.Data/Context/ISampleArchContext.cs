using SampleArch.Domain;
using SampleArch.Domain.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Data.Context
{
    public interface ISampleArchContext
    {
        int SaveChanges();
    }
}
