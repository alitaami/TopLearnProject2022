using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.User
{
    public class UserRole
    {
        public UserRole()
        {

        }
        [Key]
        public int UR_Id { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }

        #region relations
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        #endregion
    }
}
