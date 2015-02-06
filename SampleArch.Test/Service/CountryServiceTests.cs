using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleArch.Domain;
using SampleArch.Domain.Repository;
using SampleArch.Domain.Service;
using SampleArch.Domain.UnitOfWork;
using SampleArch.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Test.Service
{
    [TestClass]
    public class CountryServiceTest
    {
        private Mock<ICountryRepository> _mockRepository;
        private ICountryService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<Country> listCountry;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<ICountryRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new CountryService(_mockUnitWork.Object, _mockRepository.Object);
            listCountry = new List<Country>() {
           new Country() { Id = 1, Name = "US" },
           new Country() { Id = 2, Name = "India" },
           new Country() { Id = 3, Name = "Russia" }
          };
        }

        [TestMethod]
        public void Country_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listCountry);

            //Act
            List<Country> results = _service.GetAll() as List<Country>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Count);
        }

        [TestMethod]
        public void Can_Add_Country()
        {
            //Arrange
            int Id = 1;
            Country emp = new Country() { Name = "UK" };
            _mockRepository.Setup(m => m.Add(emp)).Returns((Country e) =>
            {
                e.Id = Id;
                return e;
            });

            //Act
            _service.Create(emp);

            //Assert
            Assert.AreEqual(Id, emp.Id);
            _mockUnitWork.Verify(m => m.Commit(), Times.Once);
        }
    }
}
