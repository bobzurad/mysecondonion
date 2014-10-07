using SampleArch.Domain.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Domain.Service
{
    public interface ICountryService : IGenericEntityService<Country>
    {
        Country GetById(int Id);
    }
}
