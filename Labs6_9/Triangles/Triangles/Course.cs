using System;
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
    }
}