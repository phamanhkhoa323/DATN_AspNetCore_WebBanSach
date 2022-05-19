using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_AspNetCore_WebBanSach.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the DATN_AspNetCore_WebBanSachUser class
    public class DATN_AspNetCore_WebBanSachUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(150)")]
        public string Address { get; set; }
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
