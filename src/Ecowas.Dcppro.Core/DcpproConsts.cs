using Ecowas.Dcppro.Debugging;

namespace Ecowas.Dcppro
{
    public class DcpproConsts
    {
        public const string LocalizationSourceName = "Dcppro";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4232ca973f9a4acfbbdf7aa7e480bb61";
    }
}
