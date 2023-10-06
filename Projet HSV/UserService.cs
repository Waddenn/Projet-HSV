using Newtonsoft.Json;

namespace Projet_HSV
{
    public class UserService
    {
        private const string FilePath = "users.json";

        public List<User> GetAllUsers()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    var content = File.ReadAllText(FilePath);
                    return JsonConvert.DeserializeObject<List<User>>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            return new List<User>();
        }
        public void SaveUser(User user)
        {
            var users = GetAllUsers();
            var existingUser = users.FirstOrDefault(u => u.FirstName == user.FirstName && u.LastName == user.LastName);
            if (existingUser != null)
            {
                users.Remove(existingUser);
            }
            users.Add(user);
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(users, Formatting.Indented));
        }

        public User GetUser(string firstname, string lastname)
        {
            return GetAllUsers().Find(u => u.FirstName == firstname && u.LastName == lastname);
        }
        public bool IsUserExist(string firstName, string lastName)
        {
            return GetUser(firstName, lastName) != null;
        }

        public bool ValidateCredentials(string firstName, string lastName, string password)
        {
            var user = GetUser(firstName, lastName);
            return user != null && user.Password == password;
        }
    }
}
