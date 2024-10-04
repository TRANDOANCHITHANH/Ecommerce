using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class KhachHang
{
    [Display(Name = "Mã Khách Hàng")]
    public string MaKh { get; set; } = null!;

    [Display(Name = "Mật Khẩu")]
    public string? MatKhau { get; set; }

    [Display(Name = "Họ Tên")]
    public string HoTen { get; set; } = null!;

    [Display(Name = "Giới Tính")]
    public bool GioiTinh { get; set; }

    [Display(Name = "Ngày Sinh")]
    public DateTime NgaySinh { get; set; }

    [Display(Name = "Địa Chỉ")]
    public string? DiaChi { get; set; }

    [Display(Name = "Điện Thoại")]
    public string? DienThoai { get; set; }

    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Display(Name = "Hình Ảnh")]
    public string? Hinh { get; set; }

    [Display(Name = "Hiệu Lực")]
    public bool HieuLuc { get; set; }

    [Display(Name = "Vai Trò")]
    public int VaiTro { get; set; }

    public string? RandomKey { get; set; }

    public virtual ICollection<BanBe> BanBes { get; set; } = new List<BanBe>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
