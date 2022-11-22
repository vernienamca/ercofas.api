using System;
using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationCoreTests.Services
{
    [TestClass]
    public class SettingsServiceServiceTests
    {
        private ISettingsRepository _repository;
        private ISettingsService _service;
        private ERCOFASContext _context;

        private DbContextOptionsBuilder<ERCOFASContext> _builder;

        [TestInitialize]
        public void Initialize()
        {
            _builder = new DbContextOptionsBuilder<ERCOFASContext>();
            _builder.UseInMemoryDatabase("TestDB" + Guid.NewGuid().ToString());

            _context = new ERCOFASContext(_builder.Options);
            _repository = new SettingsRepository(_context);
            _service = new SettingsService(_repository);
        }

        [TestMethod]
        public void CreateRepository()
        {
            Assert.IsNotNull(_service);
            Assert.IsInstanceOfType(_service, typeof(ISettingsService));
        }

        [TestMethod]
        public void Get()
        {
            var settings = CreateSettings();

            var result = _repository.Add(settings).Result;

            Assert.IsNotNull(result);
        }

        private Settings CreateSettings()
        {
            return null;
        }
    }
}
