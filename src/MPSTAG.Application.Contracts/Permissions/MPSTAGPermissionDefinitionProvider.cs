﻿using MPSTAG.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MPSTAG.Permissions;

public class MPSTAGPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MPSTAGPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MPSTAGPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MPSTAGResource>(name);
    }
}
