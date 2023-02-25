using MyOwn.Enums;
using MyOwn.Interfaces;
using MyOwn.MainProduct;
using MyOwn.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MyOwn.Service
{
    internal class Shop : IShopping
    {
        List<Product> _products = new List<Product>();
        public List<Product> Products { get=> _products; set => _products = value; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public List<Product> GetDisCountPercent()
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (var item in wantedProducts)
            {
                if (item.DisCountPercent > 0)
                {
                    wantedProducts.Add(item);
                }
            }
            return wantedProducts;
        }

        public int GetNTcount()
        {
            int count = 0;

            foreach (var item in Products)
            {
                if (item is NoteBook)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Product> GetPriceRange(byte minPrice, byte maxPrice)
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (var item in Products)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    wantedProducts.Add(item);
                }
            }
            return wantedProducts;
        }

        public int GetSPcount()
        {
            int count = 0;

            foreach (var item in Products)
            {
                if (item is SmartPhone)
                {
                    count++;
                }
            }
            return count;
        }

        public void RemoveProduct(TypeCategory category,string model)
        {
            foreach (var item in Products)
            {
                if (item.Category == category)
                {
                    Products.Remove(item);
                    break;
                }
            }
        }

        public void RemoveProduct(Product product, int index)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string value)
        {
            throw new NotImplementedException();
        }
    }
}
