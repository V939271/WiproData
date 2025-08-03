using System.Collections.Concurrent;

namespace UserManagement
{
    public class UserRepository
    {
        private readonly ConcurrentDictionary<string, User> _users =
            new ConcurrentDictionary<string, User>();

        public bool Add(User user)
        {
            return _users.TryAdd(user.UserName, user);
        }

        public User Find(string userName)
        {
            User u;
            return _users.TryGetValue(userName, out u) ? u : null;
        }
    }
}
