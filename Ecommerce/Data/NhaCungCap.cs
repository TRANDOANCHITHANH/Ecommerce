using Ecommerce.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class NhaCungCap
{
    [Display(Name = "Mã Nhà Cung Cấp")]
    public string MaNcc { get; set; } = null!;

    [Display(Name = "Tên Công Ty")]
    public string TenCongTy { get; set; } = null!;

    [Display(Name = "Logo")]
    public string Logo { get; set; } = null!;

    [Display(Name = "Người Liên Lạc")]
    public string? NguoiLienLac { get; set; }

    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Display(Name = "Điện Thoại")]
    public string? DienThoai { get; set; }

    [Display(Name = "Địa Chỉ")]
    public string? DiaChi { get; set; }

    [Display(Name = "Mô Tả")]
    public string? MoTa { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}
