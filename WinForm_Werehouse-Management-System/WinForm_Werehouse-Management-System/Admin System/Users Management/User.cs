namespace WinForm_Werehouse_Management_System
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public UserRole Role { set; get; }

        public bool IsActive { get; set; }

        public User()
        {
            IsActive = true;
        }
    }
}