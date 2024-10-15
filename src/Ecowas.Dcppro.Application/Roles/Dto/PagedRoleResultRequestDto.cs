using Abp.Application.Services.Dto;

namespace Ecowas.Dcppro.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

