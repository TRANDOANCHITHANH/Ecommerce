using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class VChiTietHoaDon
{
    public int MaCt { get; set; }

    [Display(Name = "Mã Hóa Đơn")]
    public int MaHd { get; set; }

    [Display(Name = "Mã Hàng Hóa")]
    public int MaHh { get; set; }

    [Display(Name = "Đơn Giá")]
    public double DonGia { get; set; }

    [Display(Name = "Số Lượng")]
    public int SoLuong { get; set; }

    [Display(Name = "Giảm Giá")]
    public double GiamGia { get; set; }

    [Display(Name = "Tên Hàng Hóa")]
    public string TenHh { get; set; } = null!;
}
