﻿using System.Collections.Generic;

namespace BilgeAdam.OOP.GenericTypes.Helpers
{
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Product obj)
        {
            return obj.Id;
        }
    }
}
