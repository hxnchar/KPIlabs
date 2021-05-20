using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User();
            UserAuth(user);
            Course triangle = new Course("D:/Course", user);
            while (!triangle.Alldone)
            {
                Console.WriteLine("Чи бажаєте ви переглянути лекцію?");
                if (TNtoBool(Console.ReadLine()))
                {
                    triangle.ShowNextLecture();
                }
                Console.WriteLine("Чи бажаєте ви пройти тест?");
                if (TNtoBool(Console.ReadLine()))
                {
                    triangle.ShowNextTest();
                    
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine("Вiтаємо, ви пройшли всi тести");

        }

        private static void UserAuth(User user)
        {
            Console.WriteLine("Доброго дня, чи є у вас аккаунт?Т/н");
            bool reg = !TNtoBool(Console.ReadLine());
            while (!user.Auth)
            {
                Console.WriteLine("Введiть ваш логiн");
                string login = Console.ReadLine();
                Console.WriteLine("Введiть ваш пароль");
                string password = Console.ReadLine();
                user.Authentification(reg, login, password);
                if (user.Auth)
                {
                    Console.WriteLine("Вхiд успiшно виконано");
                }
                else
                {
                    Console.WriteLine("Неправильний логiн або пароль, спробуйте знову");
                }
            }

        }

        static bool TNtoBool(string str)
        {
            return str.ToLower() == "т" || str.ToLower() == "y";
        }
    }
}