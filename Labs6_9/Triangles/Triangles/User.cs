using System.IO;

namespace Triangles
{
    public class User
    {
        private bool _auth;
        private bool _isAdmin;
        public string Name;

        public User(bool registration, string login, string password)
        {
            Name = login;
            if (registration)
            {
                if (!File.Exists("D:/courses/users.bd")) File.Create("D:/courses/users.bd");
                using (var sw = File.AppendText("D:/courses/users.bd"))
                {
                    sw.WriteLine($"{login},{password},0");
                }
                _auth = true;
            }
            else
            {
                using (var sr = new StreamReader("D:/courses/users.bd"))
                {
                    string currentString;
                    while ((currentString = sr.ReadLine()) !=null)
                    {
                        string[] parsedString = currentString.Split(",");
                        if (parsedString[0] == login && parsedString[1] == password)
                        {
                            if (parsedString[2] == "1") _isAdmin = true;
                            else _isAdmin = false;
                            _auth = true;
                        }
                    }
                }
            }
            
        }
    }
}