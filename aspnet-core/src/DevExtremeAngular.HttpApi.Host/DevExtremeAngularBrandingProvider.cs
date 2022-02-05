using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DevExtremeAngular;

[Dependency(ReplaceServices = true)]
public class DevExtremeAngularBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DevExtremeAngular";
}
