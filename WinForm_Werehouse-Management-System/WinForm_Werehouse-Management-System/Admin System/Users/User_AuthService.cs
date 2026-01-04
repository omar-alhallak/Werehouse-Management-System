using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Excptions;
using WinForm_Werehouse_Management_System.Omar.Excptions;

namespace WinForm_Werehouse_Management_System
{
    public class User_AuthService
    {
        private readonly UserService userService;

        public User_AuthService() : this(new UserService()) { }

        public User_AuthService(UserService userService1)
        {
            userService = userService1 ?? throw new ArgumentNullException(nameof(userService1));
        }

        public Users Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username=="UserName" || string.IsNullOrWhiteSpace(password) || password=="Password")
                throw new UserNameORPasswordEmptyException();

            username = username.Trim();

            var user = userService.FindByUsername(username);

            if (user == null)
                throw new UserNotFoundException();

            if (!user.IsActive)
                throw new AcountDisableException();

            bool ok = HashingFromPassword.VerifyPassword(password, user.PasswordHash);
            if (!ok)
                throw new UserNotFoundException();

            return user;
        }
    }
}