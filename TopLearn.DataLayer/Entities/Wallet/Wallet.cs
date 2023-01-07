using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TopLearn.DataLayer.Entities.Wallet
{
   public class Wallet
    {
        public Wallet()
        {


        }
        [Key]
        public int WalletId { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [ForeignKey("WalletType")]
        public int TypeId { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public int UserId { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public int Amount { get; set; }
        [Display(Name = "")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]

        public string Description { get; set; }
        [Display(Name = "")]

        public bool IsPay { get; set; }
        [Display(Name = "")]

        public DateTime CreateDate { get; set; }

        #region  relations
        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }
        #endregion

    }
}
