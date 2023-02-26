using MyOwn.Enums;
using MyOwn.MainProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwn.Interfaces
{
    internal interface IShopping
    {
        List<Product> Products { get; set; }
        void AddProduct(Product product);
        void RemoveProduct(TypeCategory category,string model);
        List<Product> Search(TypeCategory category, string value);
        List<Product> GetDisCountPercent();
        List<Product> GetPriceRange(byte minPrice, byte maxPrice);
        int GetNTcount();
        int GetSPcount();


    }
}
