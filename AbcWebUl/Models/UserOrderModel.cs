using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbcWebUl.Entity;
using AbcWebUl.Controllers;

namespace AbcWebUl.Models
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public EnumOrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }
    }
}