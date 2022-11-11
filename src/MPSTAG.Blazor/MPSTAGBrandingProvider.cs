using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MPSTAG.Blazor;

[Dependency(ReplaceServices = true)]
public class MPSTAGBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MPSTAG";
}
