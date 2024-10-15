using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Ecowas.Dcppro.Configuration.Dto;

namespace Ecowas.Dcppro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DcpproAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
