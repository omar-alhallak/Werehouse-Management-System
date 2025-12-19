using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module
{
    public class UserStorage
    {
        private readonly string FilePath;

        // لبناء مسار التخزين
        public UserStorage()
        {
            FilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data",
                "Users.json"
            );
        }

        // قراءة الحسابات من الملف
        public List<Users> LoadUsers()
        {
            EnsureFileExists();

            string json = File.ReadAllText(FilePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Users>();

            try
            {
                return JsonConvert.DeserializeObject<List<Users>>(json) ?? new List<Users>();
            }
            catch (JsonException)
            {
                return new List<Users>();
            }
        }

        //  حفظ الحسابات داخل الملف
        public void SaveUsers(List<Users> users)
        {
            EnsureDirectoryExists();

            if (users == null)
                users = new List<Users>();

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);

            File.WriteAllText(FilePath, json);
        }

        // يتأكد أن مجلد Data موجود
        private void EnsureDirectoryExists()
        {
            string dir = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        // يتأكد أن ملف users.json موجود
        private void EnsureFileExists()
        {
            EnsureDirectoryExists();

            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "[]");
        }
    }
}
