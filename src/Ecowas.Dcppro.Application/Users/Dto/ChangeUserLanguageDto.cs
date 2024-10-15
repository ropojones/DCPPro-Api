using System.ComponentModel.DataAnnotations;

namespace Ecowas.Dcppro.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}