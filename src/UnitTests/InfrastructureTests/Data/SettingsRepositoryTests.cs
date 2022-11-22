using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InfrastructureTests.Data
{
    [TestClass]
    public class SettingsRepositoryTests
    {
        private ISettingsRepository _repository;
        private ERCOFASContext _context;
        private DbContextOptionsBuilder<ERCOFASContext> _builder;

        [TestInitialize]
        public void Initialize()
        {
            _builder = new DbContextOptionsBuilder<ERCOFASContext>();
            _builder.UseInMemoryDatabase("TestDB" + Guid.NewGuid().ToString());

            _context = new ERCOFASContext(_builder.Options);
            _repository = new SettingsRepository(_context);
        }

        [TestMethod]
        public void CreateRepository()
        {
            Assert.IsNotNull(_repository);
            Assert.IsInstanceOfType(_repository, typeof(ISettingsRepository));
        }

        [TestMethod]
        public void Get()
        {
            var settings = CreateSettings();

            var result = _repository.Add(settings);

            Assert.IsNotNull(settings);
            Assert.IsNotNull(result);
        }

        private Settings CreateSettings()
        {
            return null;
        }
    }
}
