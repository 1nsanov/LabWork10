using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        private static Student[] Students = new Student[7];
        private static int Count = 1;
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = SetStudent(i);
                Console.Clear();
            }

            OutputCollection(Students);

            var listRate5 = GetCountByRate(5);
            Console.WriteLine($"Отличники: {listRate5.Count}");
            OutputCollection(listRate5);

            var listRate4 = GetCountByRate(4);
            Console.WriteLine($"Хорошисты: {listRate4.Count}");
            OutputCollection(listRate4);

            var listRate3 = GetCountByRate(3);
            Console.WriteLine($"Троечники: {listRate3.Count}");
            OutputCollection(listRate3);
            Console.ReadLine();
        }

        private static List<Student> GetCountByRate(int rate)
        {
            var listStudents = new List<Student>();
            var count = 0;
            foreach (var student in Students)
            {
                for (int i = 0; i < student.Evaluations.Length; i++)
                {
                    if (rate == 5)
                    {
                        if (student.Evaluations[i] == rate)
                        {
                            count++;
                        }
                    }
                    if (rate == 4)
                    {
                        if (student.Evaluations[i] >= rate)
                        {
                            count++;
                        }
                    }
                    if (rate == 3)
                    {
                        if (student.Evaluations[i] == rate)
                        {
                            count = 3;
                        }
                    }
                }
                if (count == 3)
                {
                    listStudents.Add(student);
                }
                count = 0;

            }

            return listStudents;
        }

        private static void OutputCollection(IEnumerable collection)
        {
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Cписок пуст.");
            }
            
        }

        private static Student SetStudent(int j)
        {
            Console.WriteLine("Введите ФИО ученика.");
            //var fullName = InputValidFullName();
            var fullName = "Test";
            var evaluations = new int[3];
            for (int i = 0; i < evaluations.Length; i++)
            {
                evaluations[i] = GenerateNumber(3, 6);
            }
            return new Student(Count++, fullName, evaluations);
        }

        private static int GenerateNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }

        private static string InputValidFullName()
        {
            while (true)
            {
                string[] checkName;
                var fullName = Console.ReadLine();
                checkName = fullName.Split(' ');
                if (checkName.Length == 3)
                {
                    return fullName;
                }
                else
                {
                    Console.WriteLine($"Введите полное имя!");
                }
            }
        }
    }
}
