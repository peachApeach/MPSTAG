using MPSTAG.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MPSTAG;

[DependsOn(
    typeof(MPSTAGEntityFrameworkCoreTestModule)
    )]
public class MPSTAGDomainTestModule : AbpModule
{

}
