using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinForm_inventory_module.CategoryManagement
{
    public class CategoryStorage
    {
        private readonly string DataFolder;
        private readonly string FilePath;

        public CategoryStorage()
        {
            DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            FilePath = Path.Combine(DataFolder, "Categories.txt");
        }

        // قراءة التصنيفات من ملف JSON
        public List<Category> Load()
        {
            EnsureFileExists();

            string json = File.ReadAllText(FilePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Category>();

            return JsonConvert.DeserializeObject<List<Category>>(json)
                   ?? new List<Category>();
        }


        // حفظ التصنيفات داخل ملف JSON
        public void Save(List<Category> categories)
        {
            EnsureDirectoryExists();

            if (categories == null)
                categories = new List<Category>();

            string json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        // يتأكد أن مجلد Data موجود
        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }

        // يتأكد أن ملف JSON موجود
        private void EnsureFileExists()
        {
            EnsureDirectoryExists();

            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "[]");
        }
    }
}
