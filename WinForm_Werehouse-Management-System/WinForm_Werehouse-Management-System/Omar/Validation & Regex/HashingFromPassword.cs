using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public static class HashingFromPassword
    {
        private const int SaltSize = 16; // ليضمن أن لكل مستخدم لديه هاش 
        private const int KeySize = 32; // طول الهاش النهائي
        private const int Iterations = 100000; // عدد مرات تكرار العملية

        // ميثود تأخد كلمة السر وتشفرها
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[SaltSize];

            // مكتبة لتوليد أرقام عشوائية آمنة
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // عملية التشفير (pbkdf2)
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(KeySize);
                return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
            }
        }

        // ميثود للتحقق من كلمة المرور
        public static bool VerifyPassword(string password, string storedHash)
        {
            // للنأكد أن الهاش ليس فارغاً
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(storedHash))
                return false;

            // نقطع النص عند كل (.) لنستخرج (التكرارات الملح الهاش) كل وحدة لحالها 
            var parts = storedHash.Split('.');
            if (parts.Length != 3) return false;

            // أستخدام (TryParse) لزيادة الأمان
            if (!int.TryParse(parts[0], out int iterations))
                return false;

            try
            {

                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] expectedHash = Convert.FromBase64String(parts[2]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] actualHash = pbkdf2.GetBytes(expectedHash.Length);
                    return FixedTimeEquals(actualHash, expectedHash);
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // لزيادة الأمان ل كلمة السر
        private static bool FixedTimeEquals(byte[] left, byte[] right)
        {
            if (left.Length != right.Length) return false;
            int diff = 0;
            for (int i = 0; i < left.Length; i++)
            {
                diff |= left[i] ^ right[i];
            }
            return diff == 0;
        }
    }
}