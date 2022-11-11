using System;
using System.Collections.Generic;
using System.Text;
using MPSTAG.Localization;
using Volo.Abp.Application.Services;

namespace MPSTAG;

/* Inherit your application services from this class.
 */
public abstract class MPSTAGAppService : ApplicationService
{
    protected MPSTAGAppService()
    {
        LocalizationResource = typeof(MPSTAGResource);
    }
}
