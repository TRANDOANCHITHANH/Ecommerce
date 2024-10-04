using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class Loai
{
    [Display(Name = "Mã Loại")]
    public int MaLoai { get; set; }

    [Display(Name = "Tên Loại")]
    public string TenLoai { get; set; } = null!;

    [Display(Name = "Tên Loại Alias")]
    public string? TenLoaiAlias { get; set; }

    [Display(Name = "Mô Tả")]
    public string? MoTa { get; set; }

    [Display(Name = "Hình Ảnh")]
    public string? Hinh { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}
