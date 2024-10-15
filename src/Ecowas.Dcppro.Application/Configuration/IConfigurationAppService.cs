using System.Threading.Tasks;
using Ecowas.Dcppro.Configuration.Dto;

namespace Ecowas.Dcppro.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
