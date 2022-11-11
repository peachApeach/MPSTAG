using MPSTAG.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MPSTAG.Blazor;

public abstract class MPSTAGComponentBase : AbpComponentBase
{
    protected MPSTAGComponentBase()
    {
        LocalizationResource = typeof(MPSTAGResource);
    }
}
