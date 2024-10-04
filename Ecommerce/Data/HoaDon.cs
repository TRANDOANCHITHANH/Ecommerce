using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class HoaDon
{
    [Display(Name = "Mã Hóa Đơn")]
    public int MaHd { get; set; }

    [Display(Name = "Mã Khách Hàng")]
    public string MaKh { get; set; } = null!;

    [Display(Name = "Ngày Đặt")]
    public DateTime NgayDat { get; set; }

    [Display(Name = "Ngày Cần")]
    public DateTime? NgayCan { get; set; }

    [Display(Name = "Ngày Giao")]
    public DateTime? NgayGiao { get; set; }

    [Display(Name = "Họ Tên")]
    public string? HoTen { get; set; }

    [Display(Name = "Địa Chỉ")]
    public string DiaChi { get; set; } = null!;

    [Display(Name = "Phương Thức Thanh Toán")]
    public string CachThanhToan { get; set; } = null!;

    [Display(Name = "Cách Vận Chuyển")]
    public string CachVanChuyen { get; set; } = null!;

    [Display(Name = "Phí Vận Chuyển")]
    public double PhiVanChuyen { get; set; }

    [Display(Name = "Mã Trạng Thái")]
    public int MaTrangThai { get; set; }

    [Display(Name = "Mã Nhân Viên")]
    public string? MaNv { get; set; }

    [Display(Name = "Ghi Chú")]
    public string? GhiChu { get; set; }

    [Display(Name = "Điện Thoại")]
    public string? DienThoai { get; set; }

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien? MaNvNavigation { get; set; }

    public virtual TrangThai MaTrangThaiNavigation { get; set; } = null!;
}
