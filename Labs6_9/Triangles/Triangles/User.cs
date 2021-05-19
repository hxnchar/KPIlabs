using System.IO;

namespace Triangles
{
    public class User
    {
        private bool _auth;
        private bool _isAdmin;
        public string Name;

        public User(string login, string password)
        {
            using (var sr = new StreamReader("D:/courses/users.bd"))
            {
                
            }
        }
    }
}