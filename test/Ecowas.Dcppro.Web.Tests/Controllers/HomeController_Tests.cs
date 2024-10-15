using System.Threading.Tasks;
using Ecowas.Dcppro.Models.TokenAuth;
using Ecowas.Dcppro.Web.Controllers;
using Shouldly;
using Xunit;

namespace Ecowas.Dcppro.Web.Tests.Controllers
{
    public class HomeController_Tests: DcpproWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}