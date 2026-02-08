namespace greenlife_organic_system.Models
{
    public abstract class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }   
        public string FullName { get; set; }
        public string Email { get; set; }

        protected User()
        {
            UserId = Guid.NewGuid().ToString();
        }

        public bool ValidateLogin(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}