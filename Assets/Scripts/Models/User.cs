namespace Models
{
    public class User
    {
        private string userName;
        private string email;
        private string password;

        public string Username
        {
            get => userName;
            set => userName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}