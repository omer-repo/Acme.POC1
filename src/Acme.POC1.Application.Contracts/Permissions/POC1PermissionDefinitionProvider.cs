using Acme.POC1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.POC1.Permissions;

public class POC1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(POC1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(POC1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<POC1Resource>(name);
    }
}
