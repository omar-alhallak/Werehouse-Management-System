using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_admin_module.Excptions;

namespace WinForm_admin_module
{
    public class UserService
    {
        private readonly UserStorage storage;
        private List<Users> users;

        public UserService()
        {
            storage = new UserStorage();
            users = storage.LoadUsers();
        }

        public List<Users> GetAllUsers()
        {
            return users.ToList();
        }

        // البحث عن مستخدم عن طريق UserName
        public Users FindByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            return users.FirstOrDefault(u =>
                u.UserName != null &&
                u.UserName.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // إضافة مستخدم جديد مع كلمة مرور مؤقتا
        public void AddUser(Users user, string plainPassword)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            //  تنظيف مدخلات بسيطة
            user.UserName = user.UserName?.Trim();
            user.FullName = user.FullName?.Trim();

            //  تأكيد أنو Username مو مكرر
            if (FindByUsername(user.UserName) != null)
                throw new UserNameAlreadyExiste();

            // تعيين Id جديد
            int nextId = (users.Count == 0) ? 100 : users.Max(u => u.Id) + 1;
            user.Id = nextId;

            // هاش لكلمة المرور وتخزينها
            user.PasswordHash = HashingFromPassword.HashPassword(plainPassword);

            // تفعيل الحساب افتراضياً
            user.IsActive = true;

            // إضافة وحفظ
            users.Add(user);
            Save();
        }

        // تعديل بيانات مستخدم بدون تغيير كلمة مرور
        public void UpdateUser(Users updatedUser)
        {
            if (updatedUser == null)
                throw new ArgumentNullException(nameof(updatedUser));

            var existing = users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existing == null)
                throw new UserNotFoundException();

            existing.FullName = updatedUser.FullName?.Trim();
            existing.Role = updatedUser.Role;
            existing.IsActive = updatedUser.IsActive;

            Save();
        }

        // تعديل كلمة المرور فقط  
        public void ChangePassword(int userId, string newPlainPassword)
        {
            if (string.IsNullOrWhiteSpace(newPlainPassword))
                throw new Exception("New password is required.");

            var user = users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new UserNotFoundException();

            user.PasswordHash = HashingFromPassword.HashPassword(newPlainPassword);
            Save();
        }

        // تعطيل الحساب 
        public void DisableUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new UserNotFoundException();

            user.IsActive = false;
            Save();
        }

        // تفعيل حساب 
        public void EnableUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new Exception("User not found.");

            user.IsActive = true;
            Save();
        }

        private void Save()
        {
            storage.SaveUsers(users);
        }
    }
}
