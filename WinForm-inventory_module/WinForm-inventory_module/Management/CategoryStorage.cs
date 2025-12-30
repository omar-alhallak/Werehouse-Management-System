using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinForm_inventory_module
{
    public class CategoryStorage
    {
        private readonly string DataFolder;
        private readonly string FilePath;

        public CategoryStorage()
        {
            DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Data");
            FilePath = Path.Combine(DataFolder, "Categories.txt");
        }

        // قراءة التصنيفات من ملف نصي
        public List<Category> Load()
        {
            EnsureFileExists();

            var list = new List<Category>();

            foreach (var line in File.ReadAllLines(FilePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split('|');
                if (parts.Length < 2)
                    continue;

                // Id
                if (!int.TryParse(parts[0], out int id))
                    continue;
                // Name
                string name = parts[1];

                var c = new Category{Id = id,Name = name};

                list.Add(c);
            }

            return list;
        }

        // حفظ التصنيفات في ملف نصي
        public void Save(List<Category> categories)
        {
            EnsureDirectoryExists();

            if (categories == null)
                categories = new List<Category>();

            var lines = new List<string>();

            foreach (var c in categories)
            {
                string line = $"{c.Id}|{c.Name}";
                lines.Add(line);
            }

            File.WriteAllLines(FilePath, lines);
        }

        // يتأكد أن مجلد Data موجود
        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }

        // يتأكد أن ملف Categories.txt موجود
        private void EnsureFileExists()
        {
            EnsureDirectoryExists();

            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "");
        }
    }
}
