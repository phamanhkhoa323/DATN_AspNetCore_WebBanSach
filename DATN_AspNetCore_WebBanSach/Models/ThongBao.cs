﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using DATN_AspNetCore_WebBanSach.Areas.Identity.Data;

namespace DATN_AspNetCore_WebBanSach.Models
{
    public class ThongBao
    {
        public int Id { get; set; }

        public string UsersId { get; set; }
        [DisplayName("Email")]
        public DATN_AspNetCore_WebBanSachUser Users { get; set; }
        [DisplayName("Nội dung")]
        public string NoiDung { get; set; }
        [DisplayName("Ngày lập")]
        [DataType(DataType.Date)]
        public DateTime NgayLap { get; set; } = DateTime.Now;
    }
}
