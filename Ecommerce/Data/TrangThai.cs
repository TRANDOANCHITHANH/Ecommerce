using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class TrangThai
{
    [Display(Name = "Mã Trạng Thái")]
    public int MaTrangThai { get; set; }

    [Display(Name = "Tên Trạng Thái")]
    public string TenTrangThai { get; set; } = null!;

    [Display(Name = "Mô Tả")]
    public string? MoTa { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
