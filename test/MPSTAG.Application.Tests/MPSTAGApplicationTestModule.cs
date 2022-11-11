using Volo.Abp.Modularity;

namespace MPSTAG;

[DependsOn(
    typeof(MPSTAGApplicationModule),
    typeof(MPSTAGDomainTestModule)
    )]
public class MPSTAGApplicationTestModule : AbpModule
{

}
