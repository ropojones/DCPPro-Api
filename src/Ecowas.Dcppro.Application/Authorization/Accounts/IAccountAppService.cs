using System.Threading.Tasks;
using Abp.Application.Services;
using Ecowas.Dcppro.Authorization.Accounts.Dto;

namespace Ecowas.Dcppro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
