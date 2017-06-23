using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DemoSample.Models.UserPermission
{
    /// <summary> 使用者 </summary>
    [DisplayName("使用者")]
    public class UserModel
    {
        public Guid? Id { get; set; }

        /// <summary> 帳號 </summary>
        [DisplayName("帳號")]
        [Required]
        [StringLength(20)]
        [MinLength(5, ErrorMessage = "長度不可小於 5")]
        [MaxLength(20, ErrorMessage = "長度不可超過 20")]
        public string Acct { get; set; }

        /// <summary> 姓名 </summary>
        [DisplayName("姓名")]
        [Required]
        [StringLength(40)]
        [MaxLength(40, ErrorMessage = "長度不可超過 40")]
        public string Name { get; set; }

        /// <summary> 連絡資訊 </summary>
        //public List<Contact> Contacts { get; set; }
    }
}