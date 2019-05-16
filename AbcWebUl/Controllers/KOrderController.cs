using AbcWebUl.Entity;
using AbcWebUl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbcWebUl.Controllers
{
    [Authorize(Roles = "admin")]
    public class KOrderController : Controller
    {
        DataContext db = new DataContext();

        // GET: KOrder
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AOrderModel()
            {
                Id = i.Id,
                OrderNumber=i.OrderNumber,
                OrderDate=i.OrderDate,
                OrderState=i.OrderState,
                Total=i.Total,
                Count=i.Orderlines.Count

            }).OrderByDescending(i =>i.OrderDate).ToList();

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
    .Select(i => new OrderDetailsModel()
    {
        OrderId = i.Id,
        UserName=i.UserName,
        OrderNumber = i.OrderNumber,
        Total = i.Total,
        OrderDate = i.OrderDate,
        OrderState = i.OrderState,
        AdresBasligi = i.AdresBasligi,
        Adres = i.Adres,
        Sehir = i.Sehir,
        Semt = i.Semt,
        Mahalle = i.Mahalle,
        PostaKodu = i.PostaKodu,
        Orderlines = i.Orderlines.Select(a => new OrderLineModel()
        {
            ProductId = a.ProdcutId,
            ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + "..." : a.Product.Name,
            Image = a.Product.Image,
            Quantity = a.Quantity,
            Price = a.Price
        }).ToList()
    }).FirstOrDefault();

            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId,EnumOrderState OrderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.Id == OrderId);

            if (order!=null)
            {
                order.OrderState = OrderState;
                db.SaveChanges();

                TempData["message"] = "Bilgileriniz Kayıt Edildi";

                return RedirectToAction("Details", new { id = OrderId });
            }

            return RedirectToAction("Index");
        }

    }
}