using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public static class ProductValidation
    {
        // Regex لاسم المنتج
        private static readonly Regex NameRegex =
            new Regex(@"^[A-Za-z0-9 _-]{2,40}$");

        // Regex لكود المنتج (مثل TEA001 — COF10 — A123)
        private static readonly Regex CodeRegex =
            new Regex(@"^[A-Z0-9]{3,15}$");

        // التحقق قبل إضافة منتج جديد
        public static void ValidateForAdd(Product product, List<Product> products)
        {
            if (product == null)
                throw new CategoryException("Product data is missing.");

            // 1) الاسم
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new CategoryException("Product name is required.");

            if (!NameRegex.IsMatch(product.Name.Trim()))
                throw new CategoryException("Invalid product name.");

            // 2) التصنيف
            if (string.IsNullOrWhiteSpace(product.CategoryName))
                throw new CategoryException("Category is required.");

            // 3) كود المنتج
            if (string.IsNullOrWhiteSpace(product.Code))
                throw new CategoryException("Product code is required.");

            if (!CodeRegex.IsMatch(product.Code.Trim()))
                throw new CategoryException("Invalid product code format.");

            // منع التكرار
            foreach (var p in products)
            {
                if (p.Id != product.Id &&
                    string.Equals(p.Code, product.Code, StringComparison.OrdinalIgnoreCase))
                {
                    throw new CategoryException("Another product already uses this code.");
                }
            }

            // 4) السعر
            if (product.UnitPrice < 0)
                throw new CategoryException("Price cannot be negative.");

            // 5) الكمية
            if (product.Stock < 0)
                throw new CategoryException("Stock cannot be negative.");
        }

        // التحقق قبل التعديل
        public static void ValidateForUpdate(Product product, List<Product> products)
        {
            ValidateForAdd(product, products);

            // السماح لنفس المنتج أن يحتفظ بكوده
            foreach (var p in products)
            {
                if (p.Id != product.Id &&
                    string.Equals(p.Code, product.Code,
                        StringComparison.OrdinalIgnoreCase))
                {
                    throw new CategoryException("Another product already uses this code.");
                }
            }
        }
    }
}
