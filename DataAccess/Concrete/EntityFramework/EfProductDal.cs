﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GettAll()
        {
            return new List<Product> { new Product { ProductName = "Kalem" }, new Product { ProductName = "Kağıt" } };
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}