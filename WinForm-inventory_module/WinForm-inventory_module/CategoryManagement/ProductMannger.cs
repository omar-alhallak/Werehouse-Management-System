using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public class ProductManager
    {
        private readonly ProductStorage storage;
        private List<Product> products;

        public ProductManager()
        {
            storage = new ProductStorage();
            products = storage.Load();
        }

        public List<Product> GetAll()
        {
            return products.ToList();
        }

        // إضافة منتج
        public void Add(Product product)
        {
            ProductValidation.ValidateForAdd(product, products);

            int newId = (products.Count == 0)
                ? 1
                : products.Max(p => p.Id) + 1;

            product.Id = newId;

            products.Add(product);
            Save();
        }

        // تعديل منتج
        public void Update(Product updated)
        {
            var existing = products.FirstOrDefault(p => p.Id == updated.Id);

            if (existing == null)
                throw new CategoryException("Product not found.");

            ProductValidation.ValidateForUpdate(updated, products);

            existing.Name = updated.Name;
            existing.CategoryName = updated.CategoryName;
            existing.Code = updated.Code;
            existing.UnitPrice = updated.UnitPrice;
            existing.Stock = updated.Stock;

            Save();
        }

        // حذف منتج
        public void Delete(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);

            if (p == null)
                throw new CategoryException("Product not found.");

            products.Remove(p);

            // إعادة ترقيم Id
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Id = i + 1;
            }

            Save();
        }

        private void Save()
        {
            storage.Save(products);
        }
    }
}
