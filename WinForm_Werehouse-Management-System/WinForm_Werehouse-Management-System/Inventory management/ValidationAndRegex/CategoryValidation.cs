using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
  
namespace WinForm_Werehouse_Management_System
{
    public static class CategoryValidation
    {

        //التحقق من صحة الاسم لازم يكون بين 2 لل30 حرف ويحتوي على حروف وارقام ومسافات وشرطات
        private static readonly Regex NameRegex =
            new Regex(@"^[A-Za-z_-]{2,30}$");
        //التحقق من الاضافة
        public static void ValidateForAdd(string name, List<Category> categories)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new CategoryException("الرجاء ادخال اسم التصنيف .");

            name = name.Trim();

            if (!NameRegex.IsMatch(name))
                throw new CategoryException("خطأ في اسم التصنيف ,يجب ان يكون بين 2-30 محرف ويحتوي على حروف وارقام ومسافات وشرطات  ");
            //لمنع التكرار الاسم اذا كان موجود مسبقا بغض النظر عن حالة الاحرف
            foreach (var c in categories)
            {
                if (string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
                    throw new CategoryException("التصنيف موجود مسبقا .");
            }
        }
        //التحقق من التعديل
        public static void ValidateForUpdate(int id, string name, List<Category> categories)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new CategoryException("الرجاء ادخال اسم التصنيف .");

            name = name.Trim();

            if (!NameRegex.IsMatch(name))
                throw new CategoryException("خطأ في اسم التصنيف ,يجب ان يكون بين 2-30 محرف ويحتوي على حروف وارقام ومسافات وشرطات  ");
            // التحقق من عدم وجود تصنيف اخر بنفس الاسم مع تجاهل التصنيف الحالي
            foreach (var c in categories)
            {
                if (c.Id != id &&
                    string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
                    throw new CategoryException("التصنيف موجود مسبقا .");
            }
        }
    }
}
