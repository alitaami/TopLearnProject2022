using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLayer.Entities.Order;

namespace TopLearn.DataLayer.Entities.User
{
    public class UserDiscountCode
    {
        [Key]
        public int UD_Id { get; set; }
        public int UserID { get; set; }
        public int DiscountId { get; set; }

        #region relations
        public User User { get; set; }
        public Discount Discount { get; set; }
        #endregion
    }
}
