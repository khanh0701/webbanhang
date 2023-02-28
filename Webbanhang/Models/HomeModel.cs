using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webbanhang.Context;
namespace Webbanhang.Models
{
    public class HomeModel
    {
        public List<LoaiSanPham> ListLoaiSanPham { get; set; }
        public List<SanPham> ListSanPham { get; set; }
    }
}