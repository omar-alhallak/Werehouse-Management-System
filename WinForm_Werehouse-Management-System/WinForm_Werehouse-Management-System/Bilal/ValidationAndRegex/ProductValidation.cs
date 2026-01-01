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

        // Regex لكود المنتج (مثل TEA001 — COF10 — A123)
        private static readonly Regex CodeRegex =
            new Regex(@"^[A-Z0-9]{3,30}$");

        // التحقق قبل إضافة منتج جديد
        public static void ValidateForAdd(Product product, List<Product> products)
        {
            if (product == null)
                throw new ProductException("الرجاء ادخال البيانات المطلوبة ");

            // 1) الاسم
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ProductException("الرجاء ادخال اسم المنتج .");

            if (!NameRegex.IsMatch(product.Name.Trim()))
                throw new ProductException("   اسم المنتج خاطئ , يجب ان يكون من 2 الى 40 حرف ويحتوي على حروف وارقام وشرطات   ");

            // 2) التصنيف
            if (string.IsNullOrWhiteSpace(product.CategoryName))
                throw new ProductException("الرجاء تحديد التصنيف ");



            // منع التكرار
            

            // 4) السعر
            if (product.UnitPrice < 0)
                throw new ProductException("السعر خاطئ");

            // 5) الكمية
            if (product.Stock < 0)
                throw new ProductException("لا يمكن ان يكون التخزين سالب");
        }

        // التحقق قبل التعديل
        public static void ValidateForUpdate(Product product, List<Product> products)
        {
            ValidateForAdd(product, products);
            
        }
    }
}
