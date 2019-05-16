using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AbcWebUl.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
      protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="Kamera", Description="Kamera ürünleri"},
                new Category() {Name="Bilgisayar", Description="Bilgisayar ürünleri"},
                new Category() {Name="Telefon", Description="Telefon ürünleri"},
                new Category() {Name="Beyaz eşya", Description="Beyaz Eşya ürünleri"},
                new Category() {Name="Tablet", Description="Tablet ürünleri"}
            };

            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
           
            context.SaveChanges();

            var urunler = new List<Product>
            {
                new Product() {Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotoğraf Makinesi",Description="resim çekmek eğlencilidir",Price=1200 ,Stock=500 ,IsApproved=true ,CategoryId=1, IsHome=true ,Image="1.jpg"},
                new Product() {Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotoğraf Makinesi",Description="resim çekmek eğlencilidir",Price=1200 ,Stock=500 ,IsApproved=true ,CategoryId=1, IsHome=true,Image="2.jpg"},
                new Product() {Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotoğraf Makinesi",Description="resim çekmek eğlencilidir",Price=1200 ,Stock=500 ,IsApproved=false ,CategoryId=1 ,Image="3.jpg"},
                new Product() {Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotoğraf Makinesi",Description="resim çekmek eğlencilidir",Price=1200 ,Stock=500 ,IsApproved=false ,CategoryId=1 ,Image="4.jpg"},
                new Product() {Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotoğraf Makinesi",Description="resim çekmek eğlencilidir",Price=1200 ,Stock=500 ,IsApproved=true ,CategoryId=1, IsHome=true,Image="5.jpg"},


                new Product() {Name="Lenovo y730 ",Description="Gaming Laptop",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=2, IsHome=true ,Image="1.jpg"},
                new Product() {Name="Asus zenbook ",Description="iş Laptop",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=2, IsHome=true ,Image="2.jpg"},
                new Product() {Name="Lenovo y730 ",Description="Gaming Laptop",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=2 ,Image="3.jpg"},
                new Product() {Name="Lenovo y730 ",Description="Gaming Laptop",Price=5000 ,Stock=500 ,IsApproved=false ,CategoryId=2 ,Image="4.jpg"},
                new Product() {Name="Lenovo y730 ",Description="Gaming Laptop",Price=5000 ,Stock=500 ,IsApproved=false ,CategoryId=2 ,Image="5.jpg"},



                new Product() {Name="Iphone X ",Description="güzel telefon",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=3, IsHome=true,Image="1.jpg"},
                new Product() {Name="Iphone 7 ",Description="güzel telefon",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=3, IsHome=true,Image="2.jpg"},
                new Product() {Name="Iphone 5 ",Description="güzel telefon",Price=5000 ,Stock=500 ,IsApproved=false ,CategoryId=3, IsHome=true,Image="3.jpg"},


                new Product() {Name="Bosh Çamaşır Makinesi ",Description="güzel",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=4, IsHome=true ,Image="1.jpg"},
                new Product() {Name="Bosh Kurutma Makinesi ",Description="güzel",Price=5000 ,Stock=500 ,IsApproved=true ,CategoryId=4,Image="2.jpg"},


               
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }

            context.SaveChanges();


            base.Seed(context);
        }
        
    }
}