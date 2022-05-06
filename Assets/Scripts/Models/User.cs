namespace Models
{
    public class User
    {
        private string username;
        private string email;
        private string password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(){}

        public User(string username, string passw, string email)
        {
            Username = username;
            Password = passw;
            Email = email;
        }

        public string Username
        {
            get => username;
            set => username = value;
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