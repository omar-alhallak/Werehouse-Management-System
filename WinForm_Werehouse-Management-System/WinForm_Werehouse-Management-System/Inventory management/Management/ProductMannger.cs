using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Exceptions;
using WinForm_Werehouse_Management_System.Omar;

namespace WinForm_Werehouse_Management_System
{
    public class ProductManager
    {
        private readonly JsonFileStorage<Product> storage;
        private List<Product> products;

        public ProductManager()
        {
            storage = new JsonFileStorage<Product>("Products.txt");
            products = storage.Load();
        }

        public List<Product> GetAll()
        {
            return products.ToList();
        }

        // إضافة منتج
        public void Add(Product product)
        {
            //  التحقق قبل الإضافة
            ProductValidation.ValidateForAdd(product, products);
            //  نحدد  Id الجديد
            int maxId = 0;

            foreach (var prod in products)
            {
                if (prod.Id > maxId)
                    maxId = prod.Id;
            }

            int newId = maxId + 1;

            //  نعطي  Id الجديد
            product.Id = newId;

            //نضيف للست
            products.Add(product);

            //  نحفظ 
            Save(); ;
        }

        // تعديل منتج
        public void Update(Product updated)
        {
            Product existing = null;

            foreach (var prod in products)
            {
                if (prod.Id == updated.Id)
                {
                    existing = prod;
                    break;
                }
            }

            ProductValidation.ValidateForUpdate(updated, products);

            existing.Name = updated.Name;
            existing.CategoryName = updated.CategoryName;
            existing.Cost = updated.Cost;
            existing.UnitPrice = updated.UnitPrice;
            existing.Stock = updated.Stock;

            Save();
        }

        // حذف منتج
        public void Delete(int id)
        {
            // نبحث عن المنتج المطلوب حسب  Id
            Product p = null;

            foreach (var prod in products)
            {
                if (prod.Id == id)
                {
                    p = prod;
                    break; // أول ما نلاقيه منطلع من اللوب
                }
            }

            
            //  حذف المنتج من القائمة
            products.Remove(p);

            //  إعادة الترقيم بعد الحذف  
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Id = i + 1;
            }

            //  حفظ القائمة بعد الترتيب في الملف
            Save();
        }
        ////

        public List<Product> Search(string searchText)
        {
            var result = new List<Product>();

            if (searchText == null)
                searchText = "";

            searchText = searchText.Trim().ToLower();

            // إذا البحث فاضي  رجّع كل المنتجات
            if (searchText == "")
            {
                foreach (var p in products)
                    result.Add(p);

                return result;
            }

            foreach (var c in products)
            {
                string name = c.Name ?? "";
                string lowerName = name.ToLower();

                if (lowerName.Contains(searchText))
                {
                    result.Add(c);
                }
            }

            return result;
        }

        public void RenameCategory(string oldName, string newName)
        {
            if (string.IsNullOrWhiteSpace(oldName) ||string.IsNullOrWhiteSpace(newName))
                return;

            bool changed = false;

            foreach (var p in products)
            {
                if (string.Equals(p.CategoryName, oldName,
                                  StringComparison.OrdinalIgnoreCase))
                {
                    p.CategoryName = newName;
                    changed = true;
                }
            }

            if (changed)
            {
                Save();   // حتى نحدّث Products.txt
            }
        }
        private void Save()
        {
            storage.Save(products);
        }
    }
}