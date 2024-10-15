using System.ComponentModel.DataAnnotations;

namespace Ecowas.Dcppro.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
