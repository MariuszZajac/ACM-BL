﻿using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId==2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription ="4Yellow sunflowers";
                product.CurrentPrice= 15.96M;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object{myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}