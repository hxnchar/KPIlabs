using System;
using System.Collections.Generic;
using System.IO;

namespace Triangles
{
    public class Course
    {
        public string Name;
        private string Path;
        public int Count;
        public bool[] Done;
        public User User;
        public bool Alldone => Done[Count - 1];

        public Course(string path, User user)
        {
            User = user;
            Path = path;
            string[] sDone;
            using (var sr = new StreamReader(path + $"/course{user.Name}.inf"))
            {
                Name = sr.ReadLine();
                Count = int.Parse(sr.ReadLine() ?? string.Empty);
                sDone = sr.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Done = new bool[Count];
            if (sDone != null)
                for (int i = 0; i < sDone.Length; i++)
                {
                    Done[i] = sDone[i] == "1";
                }
        }

        public void ShowNextLecture()
        {
            int current = 0;
            for (int i = Count - 1; i >= 0; i--)
            {
                if (!Done[i])
                {
                    current = i + 1;
                }
            }

            ShowLecture(current);
        }

        public void ShowNextTest()
        {
            int current = 0;
            for (int i = Count - 1; i >= 0; i--)
            {
                if (!Done[i])
                {
                    current = i + 1;
                }
            }

            ShowTest(current);
        }


        public void ShowLecture(int lectureNumber)
        {
            if (lectureNumber <= Count)
            {
                string lecture;
                using (var sr = new StreamReader(Path + $"/lecture{lectureNumber}.lec"))
                {
                    lecture = sr.ReadToEnd();
                }

                Console.WriteLine(lecture);
            }
            else
            {
                Console.WriteLine("This lecture does not exist");
            }
        }

        public void ShowTest(int testNumber)
        {
            if (testNumber <= Count)
            {
                int points = 0;
                int countQuestions = 0;
                string test;
                using (var sr = new StreamReader(Path + $"/test{testNumber}.tst"))
                {
                    countQuestions = int.Parse(sr.ReadLine());
                    string currentString;
                    while ((currentString = sr.ReadLine()) != null)
                    {
                        int num = 0;
                        List<string> answers = new List<string>();
                        while (num < 3)
                        {
                            answers.Add(sr.ReadLine());
                            num++;
                        }

                        Console.WriteLine(currentString);
                        OutList(answers);
                        char answer = Console.ReadLine()[0];
                        foreach (var item in answers)
                        {
                            if (item.Contains($"+{answer})")) points++;
                        }
                    }
                }

                Console.WriteLine($"Ваш результат - {points * 100 / countQuestions}%!");
                if (points * 100 / countQuestions >= 60)
                {
                    Console.WriteLine("Ви можете перейти до наступного тесту");
                    Done[testNumber - 1] = true;
                    Rewrite();
                }
                else
                {
                    Console.WriteLine("Перечитайте лекцiю уважніше, та пройдiть тест знову:)");
                }
            }
            else
            {
                Console.WriteLine("This lecture does not exist");
            }
        }

        private void Rewrite()
        {
            string sr = string.Empty;
            foreach (var dn in Done)
            {
                sr += dn ? "1 " : "0 ";
            }
            using (var sw = new StreamWriter(Path + $"/course{User.Name}.inf", false))
            {
                sw.WriteLine(Name);
                sw.WriteLine(Count);
                sw.WriteLine(sr);
            }
        }

        private static void OutList(List<string> question)
        {
            foreach (var item in question)
            {
                //string temp = item.Replace("+", "");
                Console.WriteLine(item.Replace("+", ""));
            }
        }
    }
}