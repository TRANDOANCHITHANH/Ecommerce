using Ecommerce.Data;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ViewComponents
{
    public class MenuLoai : ViewComponent
    {
        private readonly EcommerceContext db;

        public MenuLoai(EcommerceContext context) => db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
               MaLoai= lo.MaLoai,
               TenLoai= lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            });
            return View(data);
        }
    }
}
