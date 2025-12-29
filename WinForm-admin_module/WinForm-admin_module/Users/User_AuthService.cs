using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_admin_module.Excptions;

namespace WinForm_admin_module
{
    public sealed class User_AuthService
    {
        private readonly UserStorage Storage;

        public User_AuthService(UserStorage storage)
        {
            Storage = storage;
        }

        // تحقق إذا الحساب موجود ولا لاء بملف json
        public Users Login(string username, string password)
        {
            // نتأكد أنو الحقول مالها فاضية
            username = (username ?? "").Trim();
            password = password ?? "";

            const string UserPlaceholder = "UserName"; 
            const string PassPlaceholder = "Password"; 

            if (username == "" || username == UserPlaceholder)
                throw new RegexException("أدخل أسم المستخدم");

            if (password == "" || password == PassPlaceholder)
                throw new RegexException("أدخل كلمة المرور");

            // نشيل المسافات من بداية الأسم ونهايتو مشان إذا في أي خطأ أدخال
            username = username.Trim();

            // ليقرأ الحسابات من الملف
            var users = Storage.LoadUsers();

            // يدور على اليوزر
            var user = users.FirstOrDefault(u => u.UserName == username);

            // إذا اليوزر مالو موجود يحطلو أنو مالو موجود
            if (user == null)
                throw new UserNotFoundException();

            // إذا الحساب معطل يحطلو أنو معطل
            if (!user.IsActive)
                throw new RegexException("هذا الحساب ملغى تفعيله");

            // يتحقق من كلمة السر و الهاش
            bool ok = HashingFromPassword.VerifyPassword(password, user.PasswordHash);
            if (!ok)
                throw new RegexException("كلمة السر أو أسم المستخدم خاطأ");
 
            return user;
        }
    }
}