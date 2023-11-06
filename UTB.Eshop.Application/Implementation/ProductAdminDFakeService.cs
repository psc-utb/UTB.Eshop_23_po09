﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Application.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;

namespace UTB.Eshop.Application.Implementation
{
    public class ProductAdminDFakeService : IProductAdminService
    {
        IFileUploadService _fileUploadService;

        public ProductAdminDFakeService(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }

        public IList<Product> Select()
        {
            return DatabaseFake.Products;
        }

        public async void Create(Product product)
        {
            if (DatabaseFake.Products != null &&
                DatabaseFake.Products.Count > 0)
            {
                product.Id = DatabaseFake.Products.Last().Id + 1;
            }
            else
            {
                product.Id = 1;
            }

            string imageSource = await _fileUploadService.FileUploadAsync(product.Image, Path.Combine("img", "products"));
            product.ImageSrc = imageSource;

            if (DatabaseFake.Products != null)
                DatabaseFake.Products.Add(product);
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            Product? product =
                DatabaseFake.Products.FirstOrDefault(product => product.Id == id);
            
            if (product != null)
            {
                deleted = DatabaseFake.Products.Remove(product);
            }

            return deleted;
        }
    }
}
