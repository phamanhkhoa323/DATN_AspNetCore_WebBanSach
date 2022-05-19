using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using DATN_AspNetCore_WebBanSach.Areas.Identity.Data;

namespace DATN_AspNetCore_WebBanSach.Models
{
    public class HoaDon
    {
        public int Id { get; set; }
        [DisplayName("Mã hóa đơn")]
        public string MaHD { get; set; }

        public string UsersId { get; set; }
        [DisplayName("Khách hàng")]
        public DATN_AspNetCore_WebBanSachUser Users { get; set; }
        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        public string DiaChi { get; set; }
        [DisplayName("Tổng tiền")]
        public float TongTien { get; set; }

        [DisplayName("Ngày lập")]
        [DataType(DataType.Date)]
        public DateTime NgayLap { get; set; } = DateTime.Now;
        [DisplayName("Trạng thái")]
        [DefaultValue(true)]
        public bool TrangThai { get; set; } = true;



        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
