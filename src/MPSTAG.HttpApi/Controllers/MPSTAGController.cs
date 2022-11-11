using MPSTAG.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MPSTAG.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MPSTAGController : AbpControllerBase
{
    protected MPSTAGController()
    {
        LocalizationResource = typeof(MPSTAGResource);
    }
}
