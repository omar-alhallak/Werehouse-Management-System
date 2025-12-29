using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public class ProductStorage
    {
        private readonly string DataFolder;
        private readonly string FilePath;

        public ProductStorage()
        {
            DataFolder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data"
            );

            FilePath = Path.Combine(DataFolder, "Products.txt");
        }

        // تحميل المنتجات من الملف
        public List<Product> Load()
        {
            EnsureFileExists();

            var list = new List<Product>();

            foreach (var line in File.ReadAllLines(FilePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split('|');
                if (parts.Length < 6)
                    continue;

                int id = Convert.ToInt32(parts[0]);
                string name = parts[1];
                string category = parts[2];
                string code = parts[3];
                decimal price = Convert.ToDecimal(parts[4]);
                int stock = Convert.ToInt32(parts[5]);

                list.Add(new Product(id,name,category,code,price,stock));
            }

            return list;
        }

        


        // حفظ المنتجات في الملف
        public void Save(List<Product> products)
        {
            EnsureDirectoryExists();

            var lines = new List<string>();

            foreach (var p in products)
            {
                lines.Add(
                    $"{p.Id}|{p.Name}|{p.CategoryName}|{p.Code}|{p.UnitPrice}|{p.Stock}"
                );
            }

            File.WriteAllLines(FilePath, lines);
        }

        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }

        private void EnsureFileExists()
        {
            EnsureDirectoryExists();

            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "");
        }
    }
}
