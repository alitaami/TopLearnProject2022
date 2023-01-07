using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace TopLearn.DataLayer.Entities.Permission
{  
    
  public  class Permission
    { 
        
        public int PermissionId { get; set; }
        [Display(Name = "عنوان دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string PermissionTitle { get; set; }
        public int? ParentID { get; set; }

        [ForeignKey("ParentID")]
        public List<Permission> Permissions { get; set; }
        public  List<RolePermission> RolePermissions { get; set; }
    }
}
