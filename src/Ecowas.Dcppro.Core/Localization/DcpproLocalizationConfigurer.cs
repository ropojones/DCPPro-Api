using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Ecowas.Dcppro.Localization
{
    public static class DcpproLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DcpproConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DcpproLocalizationConfigurer).GetAssembly(),
                        "Ecowas.Dcppro.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
