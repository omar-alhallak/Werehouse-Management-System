using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Exceptions;

namespace WinForm_Werehouse_Management_System
{
    public static class ProductValidation
    {
        // Regex لاسم المنتج
        private static readonly Regex NameRegex =
            new Regex(@"^[A-Za-z0-9 _-]{2,40}$");

        // التحقق قبل إضافة منتج جديد
        public static void ValidateForAdd(Product product, List<Product> products)
        {
            if (product == null)
                throw new ProductException("الرجاء ادخال البيانات المطلوبة ");

            //  الاسم
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ProductException("الرجاء ادخال اسم المنتج .");

            if (!NameRegex.IsMatch(product.Name.Trim()))
                throw new ProductException("   اسم المنتج خاطئ , يجب ان يكون من 2 الى 40 حرف ويحتوي على حروف وارقام وشرطات   ");

            //  التصنيف
            if (string.IsNullOrWhiteSpace(product.CategoryName))
                throw new ProductException("الرجاء تحديد التصنيف ");

            //  السعر
            if (product.UnitPrice < 0 )
                throw new ProductException("السعر خاطئ");

            //  الكمية
            if (product.Stock < 0)
                throw new ProductException("لا يمكن ان يكون التخزين سالب");

            // منع التكرار
            foreach (var p in products)
            {
                if (p.Id != product.Id && string.Equals(p.Name, product.Name, StringComparison.OrdinalIgnoreCase)) 
                {
                    throw new ProductException("المنتج موجود مسبقاً");
                }
            }
        }

        // التحقق قبل التعديل
        public static void ValidateForUpdate(Product product, List<Product> products)
        {
            ValidateForAdd(product, products);
            
        }
    }
}