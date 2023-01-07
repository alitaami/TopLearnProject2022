using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.Permission;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IPermissionService
    {
        List<Role> GetRoles();
        void AddRolesToUser(List<int> SelectedRoles , int userid);
        void EditRolesUser(List<int> RolesId, int userid);
        int addrole(Role  role);
        Role  GetRoleById(int roleId);
        void updateRole(Role  role);
        void deleterole(Role  role);

        #region permission
        List<Permission> GetPermissions();
        void AddPermissionToRole(int roleId, List<int> SelectedPermission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);

        bool Checkpermission(int permissionId, string username);
        #endregion
    }
}
