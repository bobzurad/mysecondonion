using SampleArch.Domain;
using SampleArch.Domain.Repository;
using SampleArch.Domain.Service;
using SampleArch.Domain.UnitOfWork;
using SampleArch.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Service
{
    public class CountryService : GenericEntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }


        public Country GetById(int Id)
        {
            return _countryRepository.GetById(Id);
        }
    }
}
