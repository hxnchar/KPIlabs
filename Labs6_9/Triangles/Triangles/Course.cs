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

        public Course(string path)
        {
            Path = path;
            using (var sr = new StreamReader(path + "/course.inf"))
            {
                Name = sr.ReadLine();
                Count = int.Parse(sr.ReadLine() ?? string.Empty);
            }
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
                Console.WriteLine($"Ваш результат - {points*100/countQuestions}%!");
            }
            else
            {
                Console.WriteLine("This lecture does not exist");
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