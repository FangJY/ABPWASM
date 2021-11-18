using ABPWASM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPWASM.Permissions
{
    public class ABPWASMPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ABPWASMPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ABPWASMPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ABPWASMResource>(name);
        }
    }
}
