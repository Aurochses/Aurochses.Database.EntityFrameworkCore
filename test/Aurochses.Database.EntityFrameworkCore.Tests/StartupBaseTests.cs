using System.Collections.Generic;
using Aurochses.Database.EntityFrameworkCore.Tests.Fakes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Aurochses.Database.EntityFrameworkCore.Tests
{
    public class StartupBaseTests
    {
        [Fact]
        public void Configuration_Get_Success()
        {
            // Arrange
            IConfiguration configuration = new ConfigurationRoot(new List<IConfigurationProvider>());

            var startupBase = new FakeStartupBase(configuration);

            // Act & Assert
            Assert.Equal(configuration, startupBase.Configuration);
        }

        [Fact]
        public void ConfigureServices_Success()
        {
            // Arrange & Act & Assert
            new FakeStartupBase(null).ConfigureServices(new ServiceCollection());
        }

        [Fact]
        public void Configure_Success()
        {
            // Arrange & Act & Assert
            new FakeStartupBase(null).Configure();
        }
    }
}