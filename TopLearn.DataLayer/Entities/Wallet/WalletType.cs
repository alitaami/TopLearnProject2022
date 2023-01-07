using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TopLearn.DataLayer.Entities.Wallet
{
   public class WalletType
    {
        public WalletType()
        {

        }

        //نمیخواهیم به صورت خودکار عدد گذاری شود بخاطر آن چنین صقتی در نظر گرفتیم
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }
        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }

        #region  relations
        public virtual List<Wallet> Wallets { get; set; }
        #endregion
    }
}
