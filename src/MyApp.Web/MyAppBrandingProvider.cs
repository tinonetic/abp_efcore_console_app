using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyApp.Web
{
    [Dependency(ReplaceServices = true)]
    public class MyAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MyApp";
    }
}
