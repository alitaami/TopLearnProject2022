using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.User
{
  public  class Role
    {
        public Role()
        {

        }
        [Key]
        public int RoleId { get; set; }
        
        [Display(Name ="نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیتواند بیشتر از {1} کاراکتر باشد")]  
        public string RoleTitle { get; set; }
        public bool IsDelete { get; set; }

        #region relations
        public virtual List<UserRole> UserRoles { get; set; }
        public  List<Permission.RolePermission> RolePermissions { get; set; }
        #endregion
    }
}
