using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System.Omar
{
    public class JsonFileStorage<T>
    {
        private readonly string filePath;

        // يبني المسار و ينشئ المجلد مباشرة
        public JsonFileStorage(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("File name is required.", nameof(fileName));
       
            string projectRoot = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")
            );

            string dataFolder = Path.Combine(projectRoot, "Data");

            Directory.CreateDirectory(dataFolder);

            filePath = Path.Combine(dataFolder, fileName);
        }

        public List<T> Load()
        {
            EnsureFileExists();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            try
            {
                var list = JsonConvert.DeserializeObject<List<T>>(json);
                return list ?? new List<T>();
            }
            catch (JsonException)
            {
                return new List<T>();
            }
        }

        public void Save(IEnumerable<T> items)
        {
            var list = items?.ToList() ?? new List<T>();

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(filePath, json);
        }

        //public string FilePath => filePath;

        private void EnsureFileExists()
        {
            string dir = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "[]");
        }
    }
}