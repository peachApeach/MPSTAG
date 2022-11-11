using MPSTAG.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MPSTAG.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MPSTAGEntityFrameworkCoreModule),
    typeof(MPSTAGApplicationContractsModule)
    )]
public class MPSTAGDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
