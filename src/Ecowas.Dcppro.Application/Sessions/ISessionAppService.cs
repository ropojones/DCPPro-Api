using System.Threading.Tasks;
using Abp.Application.Services;
using Ecowas.Dcppro.Sessions.Dto;

namespace Ecowas.Dcppro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
