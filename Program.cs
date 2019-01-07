using System;
using System.Linq;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Ілля", "Федорович", new DateTime(2000, 5, 8), Student.Education.Bachelor, "ІП-71", 7327, new List<Examination>{
                new Examination(1, "ООП-1", new List<string>{"Муха", "І.П."}, 100, true, new DateTime(2019, 1, 9))
            });
            Console.WriteLine(st.ToString());
            st.AddExams(new List<Examination>{
                new Examination(1, "ТЙіМС", new List<string>{"Гарко", "І.І."}, 75, true, new DateTime(2019, 1, 14)),
                new Examination(1, "Філософія", new List<string>{"Куцик", "К.М."}, 92, false, new DateTime(2018, 12, 26)),
                new Examination(1, "АК", new List<string>{"Коган", "А.В."}, 99, true, new DateTime(2019, 1, 17)),
                new Examination(1, "Психологія конфлікту", new List<string>{"Кононець", "М.О."}, 85, false, new DateTime(2018, 12, 27))
            });
            Console.WriteLine(st.ToString());
            st.PrintFullInfo();

            Console.WriteLine();
            Console.WriteLine("-------- Завдання 1 (1 в списку) --------");
            Student st2 = (Student)st.Clone();
            Console.Write("Студент 1: ");
            st.PrintFullInfo();
            Console.Write("Студент 2: ");
            st2.PrintFullInfo();

            Console.WriteLine();
            Console.WriteLine("-------- Завдання 2 (2 в списку) --------");
            Console.WriteLine("st.ReferenceEquals(st2): " + Object.ReferenceEquals(st, st2));
            Console.WriteLine("st == st2: " + (st == st2));
            Person p1 = (Person) st;
            Person p2 = (Person) st2; 
            Console.WriteLine("Person порівняння: " + (p1 == p2));

            Console.WriteLine();
            Console.WriteLine("-------- Завдання 3 (9 в списку) --------");
            Console.Write("Заліки: ");
            foreach (Examination e in st.NotMarked()) {
                Console.Write(e.ToString() + ", ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-------- Завдання 4 (12 в списку) --------");
            Console.WriteLine(st.getSortedExams().Aggregate("", (a, v) => a + v.ToString() + "\n"));
        }
    }
}
