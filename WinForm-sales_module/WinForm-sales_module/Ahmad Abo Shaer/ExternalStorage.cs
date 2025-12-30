using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml;


namespace WinForm_sales_module
{
    public static class ExternalStorage
    {
        private static readonly string BasePath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WinFormSalesData");

        static ExternalStorage()
        {
            if (!Directory.Exists(BasePath))
                Directory.CreateDirectory(BasePath);
        }

        public static void Save<T>(string fileName, T data)
        {
            string path = Path.Combine(BasePath, fileName);

            var json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static T Load<T>(string fileName) where T : new()
        {
            string path = Path.Combine(BasePath, fileName);

            // إذا لم يكن الملف موجودًا، ننشئه ونضع فيه كائنًا فارغًا
            if (!File.Exists(path))
            {
                var emptyData = new T();
                var json = JsonConvert.SerializeObject(emptyData, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
                return emptyData;
            }

            var fileContent = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(fileContent))
                return new T();

            return JsonConvert.DeserializeObject<T>(fileContent);
        }

    }


}
