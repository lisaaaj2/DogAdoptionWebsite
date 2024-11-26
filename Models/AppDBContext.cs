namespace Dog_Adoption_Website.Data
{
    public class AppDBContext
    {
        private static List<User> _users = new List<User>();

        public static bool SaveUser(User user)
        {
            bool isExist = _users.Any(x => x.Email == user.Email);
            if (!isExist)
            {
                _users.Add(user);
                return true;

            }
            return false;
        }

    }

    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}

