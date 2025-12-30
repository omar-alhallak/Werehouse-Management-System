using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinForm_admin_module
{
    public static class RegexValidator
    {
        public static bool RegexFromUserName(string userName, out string error)
        {
            // أسم المستخدم لا يمكن أن يكون فارغ
            // يجب أن يحتوي على حروف إنجليزية وأرقام فقط
            // طوله بين 4 و 15 محرف
            // يسمح فقط برموز الأتية ( _ - ) فقط 
            error = null;

            const string pattern = @"^[a-zA-Z0-9\-_]{4,15}$";

            if (string.IsNullOrEmpty(userName)||userName== "UserName")
            {
                error = "_ أسم المستخدم لا يمكن أن يكون فارغ.";
                return false;
            }
            userName = userName.Trim();

            if (!Regex.IsMatch(userName, pattern))
            {
                error = "- اسم المستخدم غير صالح. يجب أن يحتوي على حروف إنجليزية وأرقام فقط، وطوله بين 4 و 15 محرف. \n - يسمح فقط برموز الأتية ( _ - ) فقط.";
                return false;
            }

            return true;
        }

        public static bool RegexFromFullName(string fullName, out string error)
        {
            //  الاسم الكامل لا يمكن أن يكون فارغ
            // يسمح فقط بأستخدتم أحرف أجنبية
            // حد الأقصى للمحارف 30
            // حد أقل 4 محارف
            error = null;  

            if (string.IsNullOrWhiteSpace(fullName) || fullName == "Full Name")
            {
                error = "_ الاسم الكامل لا يمكن أن يكون فارغ.";
                return false;
            }
            fullName = fullName.Trim();

            const string pattern = @"^[a-zA-Z\s]{4,30}$";

            if (!Regex.IsMatch(fullName, pattern))
            {
                error = "_ الاسم الكامل غير صالح. يجب أن يحتوي على أحرف أجنبية ومسافات فقط، وبحد أقصى 30 محرف. وحد أقل 4 محارف.";
                return false;
            }
            return true;
        }

        public static bool RegexFromPassword(string password, out string error)
        {
            // يجب أن تحوي على 8 محارف على الأقل
            // يجب أن تحوي على حرف كبير واحد على الأقل
            // يجب أن تحوي على رقم واحد على الأقل
            // يجب أن تحوي على رمز خاص واحد على الأقل
            error = null;

            if (string.IsNullOrWhiteSpace(password) || password == "Password")
            {
                error = "_ كلمة المرور لا يمكن أن تكون فارغة.";
                return false;
            }

            bool isValid = true;
            string Massage = "كلمة المرور ضعيفة. يجب أن تستوفي الشروط التالية :\n";

            if (password.Length < 8)
            {
                Massage += "_ يجب أن تحوي على 8 محارف على الأقل.\n";
                isValid = false;
            }
            if (!Regex.IsMatch(password, @"[A-Z]+"))
            {
                Massage += "_ يجب أن تحوي على حرف كبير واحد على الأقل.\n";
                isValid = false;
            }
            if (!Regex.IsMatch(password, @"[0-9]+"))
            {
                Massage += "_ يجب أن تحوي على رقم واحد على الأقل.\n";
                isValid = false;
            }
            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9]+"))
            {
                Massage += "_ يجب أن تحوي على رمز خاص واحد على الأقل.\n";
                isValid = false;
            }

            if (!isValid)
            {
                error = Massage;
                return false;
            }
            return true;
        }
    }
}