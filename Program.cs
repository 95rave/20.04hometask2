using System;

namespace _20._04task2update
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ravana", "Piriyeva", "P324 ", 85, false);
            student.getInfo();
            student.ExamChance();

        }

    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool Graduated;

        public Student(string name, string surname, string group, byte point, bool graduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            Graduated = graduated;
        }

        public void getInfo()
        {
            Console.WriteLine($"Name: {Name} \n Surname: {Surname} \n Group: {Group} \n Point: {Point} \n Graduated: {(Graduated ? "Graduated" : "Not graduated")}");
        }

        public void ExamChance()
        {
            Console.WriteLine($"{(Point > 80 ? $"Allowed to take the exam" : $"Are not allowed to take the exam")}");
        }
    }
}
