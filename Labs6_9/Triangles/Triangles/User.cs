using System.IO;

namespace Triangles
{
    public class User
    {
        private bool _auth;
        private bool _isAdmin;

        public bool Auth => _auth;
        public string Name;

        public User()
        {
            _auth = false;
            _isAdmin = false;
        }

        public void Authentification(bool registration, string login, string password)
        {
            Name = login;
            if (registration)
            {
                if (!File.Exists("D:/course/users.bd")) File.Create("D:/course/users.bd");
                using (var sw = File.AppendText("D:/course/users.bd"))
                {
                    sw.WriteLine($"{login},{password},0");
                }
                File.Copy("D:/course/course.inf",$"D:/course/course{login}.inf");
                _auth = true;
            }
            else
            {
                using (var sr = new StreamReader("D:/course/users.bd"))
                {
                    string currentString;
                    while ((currentString = sr.ReadLine()) != null)
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