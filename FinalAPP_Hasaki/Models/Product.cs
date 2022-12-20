using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAPP_Hasaki.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public double ProductRating { get; set; }
        public string ProductImageUrl { get; set; }
        public static List<Product> KhoitaoProducts()
        {
            List<Product> DSProducts;
            DSProducts = new List<Product>();
            DSProducts.Add(new Product { ProductID = 1, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 1, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product1.jpg" });
            DSProducts.Add(new Product { ProductID = 2, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 1, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product2.jpg" });
            DSProducts.Add(new Product { ProductID = 3, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 3, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product3.jpg" });
            DSProducts.Add(new Product { ProductID = 4, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 3, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product4.jpg" });
            DSProducts.Add(new Product { ProductID = 5, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 4, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product5.jpg" });
            DSProducts.Add(new Product { ProductID = 6, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 3, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product6.jpg" });
            DSProducts.Add(new Product { ProductID = 7, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 2, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product7.jpg" });
            DSProducts.Add(new Product { ProductID = 8, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 5, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product8.jpg" });
            DSProducts.Add(new Product { ProductID = 9, ProductName = "ĐÂY LÀ TÊN SẢN PHẨM", ProductTypeId = 6, ProductPrice = 200000, ProductRating = 4.9, ProductImageUrl = "img_product9.jpg" });
            return DSProducts;
        }
    }
}
