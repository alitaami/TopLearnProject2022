using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Permission;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private TopLearnContext _context;
        public PermissionService(TopLearnContext context)
        {
            _context = context;
        }

        public void AddPermissionToRole(int roleId, List<int> SelectedPermission)
        {
            foreach (var p in SelectedPermission)
            {
                _context.RolePermission.Add(new RolePermission()
                {

                    PermissionId = p,
                    RoleId = roleId

                });
            }
            _context.SaveChanges();
        }

        public int addrole(Role  role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolesToUser(List<int> SelectedRoles, int userid)
        {
            foreach (int roleId in SelectedRoles)
            {
               _context.UserRoles.Add(new UserRole()
                {
                    RoleID = roleId,
                    UserID = userid

                });
                _context.SaveChanges();
            }
        }

        public bool Checkpermission(int permissionId, string username)
        {
            int userid = _context.Users.Single(u => u.UserName == username).UserId;
            List<int> UserRoles = _context.UserRoles.Where(u => u.UserID == userid).Select(r => r.RoleID).ToList();
            if (UserRoles == null)
            {
                return false;
            }
            List<int> RolesPermission = _context.RolePermission
                .Where(r => r.PermissionId == permissionId)
                .Select(r => r.RoleId).ToList();

            return RolesPermission.Any(p => UserRoles.Contains(p));

        }

        public void deleterole(Role  role)
        {
            role.IsDelete = true;
            updateRole(role);
          
        }

        public void EditRolesUser(List<int> RolesId, int userid)
        {

            // delete old roles
            _context.UserRoles.Where(r => r.UserID == userid).ToList().ForEach(r => _context.UserRoles.Remove(r));
           

            //add new roles
            AddRolesToUser(RolesId, userid);
        }

        public List<Permission> GetPermissions()
        {
            return _context.permission.ToList();
                
        }

        public Role  GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermission
               .Where(r => r.RoleId == roleId)
               .Select(r => r.PermissionId).ToList();
        }

        public void UpdatePermissionsRole(int roleId, List<int> permissions)
        {
            _context.RolePermission.Where(p => p.RoleId == roleId)
                .ToList().ForEach(p => _context.RolePermission.Remove(p));

            AddPermissionToRole(roleId, permissions);
        }

        public void updateRole(Role  role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
    }
}
