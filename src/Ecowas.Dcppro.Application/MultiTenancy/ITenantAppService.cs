using Abp.Application.Services;
using Ecowas.Dcppro.MultiTenancy.Dto;

namespace Ecowas.Dcppro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

