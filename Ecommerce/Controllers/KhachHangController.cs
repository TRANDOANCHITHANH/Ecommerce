using AutoMapper;
using Ecommerce.Data;
using Ecommerce.Helpers;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Ecommerce.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly EcommerceContext db;
        private readonly IMapper _mapper;

        public KhachHangController(EcommerceContext context,IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }
        #region Register
        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DangKy(RegisterVM model,IFormFile Hinh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var khachHang = _mapper.Map<KhachHang>(model);
                    khachHang.RandomKey = MyUtil.GenerateRamdomKey();
                    khachHang.MatKhau = model.MatKhau.ToMd5Hash(khachHang.RandomKey);
                    khachHang.HieuLuc = true;
                    khachHang.VaiTro = 0;
                    if (Hinh != null)
                    {
                        khachHang.Hinh = MyUtil.UpLoadHinh(Hinh, "KhachHang");
                    }
                    db.Add(khachHang);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            } catch (Exception ex)
            {
                var mess = $"{ex.Message} shh";
            }
            return View();
        }
        #endregion
        #region Login in 
        [HttpGet]
        public IActionResult DangNhap(string? ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;  

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DangNhap(LoginVM model, string? returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            if(ModelState.IsValid)
            {
                var khachHang = db.KhachHangs.SingleOrDefault(kh=>kh.MaKh == model.UserName);
                if(khachHang == null)
                {
                    ModelState.AddModelError("Lỗi", "Không có khách hàng này");
                }
                else
                {
                    if (!khachHang.HieuLuc)
                    {
                        ModelState.AddModelError("Lỗi", "Tài khoản đã bị khóa. Vui lòng liên hệ Admin");
                    }
                    else
                    {
                        if(khachHang.MatKhau!=model.Password.ToMd5Hash(khachHang.RandomKey)) {
                            ModelState.AddModelError("Lỗi", "Sai thông tin đăng nhập");
                        }else
                        {
                            var claims = new List<Claim> {
                            new Claim(ClaimTypes.Email,khachHang.Email),
                            new Claim(ClaimTypes.Name,khachHang.HoTen),
                            new Claim(MySetting.CLAIM_CUSTOMERID,khachHang.MaKh),
                            new Claim(ClaimTypes.Role,"Customer")

                            };
                            var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                            await HttpContext.SignInAsync(claimsPrincipal);
                            if (Url.IsLocalUrl(returnUrl))
                            {
                                return Redirect(returnUrl);
                            }
                            else
                            {
                                return Redirect("/");
                            }
                        }
                    }
                }
            }
            return View();
        }
        #endregion
        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> DangXuat()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
