using System;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            UTBTable<int> numbers = new UTBTable<int>("numbers");

            UTBTable<Student> students = new UTBTable<Student>("students");
            
            UTBTable<Lecture> lectures = new UTBTable<Lecture>("lectures");

            UTBTable<ForeignStudent> foreigners = new UTBTable<ForeignStudent>("foreginers");

            /*
            Student s1 = new Student();
            s1.Name = "Jan";
            s1.Semester = 7;

            Student s2 = new Student();
            s2.Name = "Ana";
            s2.Semester = 1;

            Student s3 = new Student();
            s3.Name = "Michal";
            s3.Semester = 9;

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            students.Save();
            Console.WriteLine("Students table saved!");
            */

            students.Read();
            Console.WriteLine("Students were retrieved from the file");

            foreach (Student s in students.Data)
            {
                Console.WriteLine(s.Name + "\t" + s.Semester);
            }

            lectures.Add(new Lecture()
            {
                Title = "Generic programming",
                LectureDateTime = DateTime.Now.AddHours(-1)
            });

            lectures.Save();

            Console.ReadKey();
        }
    }
}
