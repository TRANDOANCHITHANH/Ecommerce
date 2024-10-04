using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data;

public partial class HangHoa
{
    public int MaHh { get; set; }
    [Display(Name = "Tên Hàng Hóa")]
    public string TenHh { get; set; } = null!;
    [Display(Name = "Tên Alias")]
    public string? TenAlias { get; set; }
    [Display(Name = "Mã Loại")]
    public int MaLoai { get; set; }
    [Display(Name = "Đơn Vị")]
    public string? MoTaDonVi { get; set; }
    [Display(Name = "Đơn Giá")]
    public double? DonGia { get; set; }
    [Display(Name = "Hình Ảnh")]
    public string? Hinh { get; set; }
    [Display(Name = "Ngày Sản Xuất")]
    public DateTime NgaySx { get; set; }
    [Display(Name = "Giảm Giá")]
    public double GiamGia { get; set; }
    [Display(Name = "Số Lượt Xem")]
    public int SoLanXem { get; set; }
    [Display(Name = "Mô Tả")]
    public string? MoTa { get; set; }
    [Display(Name = "Nhà Cung Cấp")]
    public string MaNcc { get; set; } = null!;

    public virtual ICollection<BanBe> BanBes { get; set; } = new List<BanBe>();

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual Loai MaLoaiNavigation { get; set; } = null!;

    public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
