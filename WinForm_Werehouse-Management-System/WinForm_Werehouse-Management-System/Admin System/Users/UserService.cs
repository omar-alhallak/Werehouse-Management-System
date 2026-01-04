using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Excptions;
using WinForm_Werehouse_Management_System.Omar;

namespace WinForm_Werehouse_Management_System
{
    public sealed class UserService
    {
        private readonly JsonFileStorage<Users> storage;
        private List<Users> users;

        public UserService()
        {
            storage = new JsonFileStorage<Users>("Users.txt");
            users = storage.Load();
        }

        public List<Users> GetAllUsers()
        {
            users = storage.Load();
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

        // إضافة مستخدم جديد مع كلمة مرور
        public void AddUser(Users user, string plainPassword)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            user.UserName = user.UserName?.Trim();
            user.FullName = user.FullName?.Trim();

            if (FindByUsername(user.UserName) != null)
                throw new UserNameAlreadyExiste();

            int nextId = (users.Count == 0) ? 100 : users.Max(u => u.Id) + 1;
            user.Id = nextId;

            user.PasswordHash = HashingFromPassword.HashPassword(plainPassword);
            user.IsActive = true;

            users.Add(user);
            Save();
        }

        // (تعديل بيانات المستخدم (الاسم الكامل، الصلاحية، الحالة
        public void UpdateUser(Users updatedUser)
        {
            if (updatedUser == null)
                throw new ArgumentNullException(nameof(updatedUser));

            var existing = users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existing == null)
                throw new UserNotFoundException();

            existing.UserName = updatedUser.UserName?.Trim();
            existing.FullName = updatedUser.FullName?.Trim();
            existing.Role = updatedUser.Role;
            existing.IsActive = updatedUser.IsActive;

            Save();
        }

        // تعديل كلمة المرور فقط
        public void ChangePassword(int userId, string newPlainPassword)
        {
            if (string.IsNullOrWhiteSpace(newPlainPassword))
                throw new ArgumentException("New password is required.", nameof(newPlainPassword));

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

        // تفعيل الحساب
        public void EnableUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new UserNotFoundException();

            user.IsActive = true;
            Save();
        }

        private void Save()
        {
            storage.Save(users);
        }
    }
}