using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module   
{
    public class CategoryManager
    {
        //تخزين و تحميل التصنيفات
        private readonly CategoryStorage Storage;
        private List<Category> Categories;

        public CategoryManager()
        {
            Storage =new CategoryStorage();
            Categories = Storage.Load();
        }

        // منشان نرجع كل التصنيفات
        public List<Category> GetAll()
        {
            return Categories;
        }

        // إضافة تصنيف
        public void Add(string name)
        {
            //  التحقق قبل الإضافة
            CategoryValidation.ValidateForAdd(name, Categories);

            //  نحدد  Id الجديد
            int maxId = 0;

            foreach (var cat in Categories)
            {
                if (cat.Id > maxId)
                    maxId = cat.Id;
            }

            int newId = maxId + 1;

            //  نضيف التصنيف الجديد
            Categories.Add(new Category(newId, name.Trim()));

            //  نحفظ التعديلات في الملف
            Storage.Save(Categories);
        }

        // تعديل تصنيف
        public void Update(int id, string name)
        {
            CategoryValidation.ValidateForUpdate(id, name, Categories);

            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].Id == id)
                {
                    Categories[i] = new Category(id, name.Trim());
                    Storage.Save(Categories);
                    return;
                }
            }

            throw new CategoryException("Category not found.");
        }

        // حذف تصنيف
        public void Delete(int id)
        {
            // 1) نبحث عن التصنيف المطلوب
            Category c = default(Category);
            bool found = false;

            foreach (var cat in Categories)
            {
                if (cat.Id == id)
                {
                    c = cat;
                    found = true;
                    break;
                }
            }

            // 2) إذا ما لقيناه  منرمي استثناء
            if (!found)
                throw new CategoryException("Category not found.");

            // 3) حذف التصنيف
            Categories.Remove(c);

            // 4) إعادة الترقيم بعد الحذف
            for (int i = 0; i < Categories.Count; i++)
            {
                var item = Categories[i];
                Categories[i] = new Category(i + 1, item.Name);
            }

            // 5) حفظ بعد إعادة الترتيب
            Storage.Save(Categories);
        }

        //
        public List<Category> Search(string searchText)
        {
            // ليست لتخزين النتائج
            var result = new List<Category>();

            // نحول النص لاحرف صغيرة ونتخلص من الفراغات
            if (searchText == null)
                searchText = "";

            searchText = searchText.Trim().ToLower();

            //اذا البحث فارغ رجع كلشي
            if (searchText == "")
            {
                foreach (var c in Categories)
                    result.Add(c);

                return result;
            }

            // فلترة حسب النص المدخل
            foreach (var c in Categories)
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

    }
}
