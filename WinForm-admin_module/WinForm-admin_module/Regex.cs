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
            
        public static bool RegexFromUserName(string UserName)
        {
            // يسمح فقط بلأحرف الأجنبية
            // يسمح بكتابة أحرف أجنبية + أرقام
            // يسمح على الأقل بأستخدتم 3 محارف و على الأكثر 15 محرف
            // إذالة المسافات من بداية ونهاية الأسم
            const string UserNamePattern = @"^[a-zA-Z0-9]{4,15}$";

            UserName = UserName.Trim();

            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("اسم المستخدم لا يمكن أن يكون فارغاً.", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(UserName, UserNamePattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("اسم المستخدم غير صالح. يجب أن يحتوي على حروف الإنجليزية وأرقام فقط، وطوله بين 3 و 15 محرف.",
                                "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool RegexFromPassword(string Password)
        {
            // يجب أن تحوي على 8 حروف على الأقل
            // يجب أن تحوي على حرف كبير واحد على الأقل
            // يجب أن تحوي على رقم واحد على الأقل
            // يجب أن تحوي على رمز خاص واحد على الأقل

            bool isValid = true;
            string errorMessage = "كلمة المرور ضعيفة. يجب أن تفي بالشروط التالية:\n";

            if (Password.Length < 8)
            {
                errorMessage += " - يجب أن يحوي على 8 حروف على الأقل.\n";
                isValid = false;
            }
            if (!Regex.IsMatch(Password, @"[A-Z]+")) 
            {
                errorMessage += " - يجب أن يحوي على حرف كبير واحد على الأقل.\n";
                isValid = false;
            }

            if (!Regex.IsMatch(Password, @"[0-9]+")) 
            {
                errorMessage += " - يجب أن يحوي على رقم واحد على الأقل.\n";
                isValid = false;
            }

            if (!Regex.IsMatch(Password, @"[^a-zA-Z0-9]+")) 
            {
                errorMessage += " - يجب أن يحوي على رمز خاص ( @, #, $ ) واحد على الأقل.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "كلمة المرور غير آمنة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }
    }
}