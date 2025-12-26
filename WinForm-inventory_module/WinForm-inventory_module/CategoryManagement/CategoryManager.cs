using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public class CategoryManager
    {
        private readonly CategoryStorage Storage;
        private List<Category> Categories;

        public CategoryManager()
        {
            Storage =new CategoryStorage();
            Categories = Storage.Load();
        }

        // ترجع كل التصنيفات
        public List<Category> GetAll()
        {
            return Categories;
        }

        // توليد ID جديد
        public int GetNextId()
        {
            int max = 0;
            foreach (var c in Categories)
            {
                if (c.Id > max) max = c.Id;
            }
            return max + 1;
        }

        // إضافة تصنيف
        public void Add(string name)
        {
            CategoryValidation.ValidateForAdd(name, Categories);

            int id = GetNextId();
            Categories.Add(new Category(id, name.Trim()));

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
            var c = Categories.FirstOrDefault(x => x.Id == id);

            if (c.Equals(default(Category)))
                throw new CategoryException("Category not found.");

            // 1) حذف التصنيف
            Categories.Remove(c);

            // 2) إعادة ترقيم Ids من 1 إلى n
            for (int i = 0; i < Categories.Count; i++)
            {
                var item = Categories[i];
                Categories[i] = new Category(i + 1, item.Name);
            }

            // 3) حفظ بعد إعادة الترتيب
            Storage.Save(Categories);
          
        }
    }
}
