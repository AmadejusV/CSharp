using System;
using System.Collections.Generic;
using System.Linq;

namespace Paskaita2020._10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("aurimas"); //ideda i stack
            myStack.Push("test");
            myStack.Push("foo");
            myStack.Push("bar");

            //string mytest = myStack.Peek();          //neaisku
            //mytest = "testmy";

            //Console.WriteLine(myStack.Peek());   //parodo
            //Console.WriteLine(myStack.Pop());   //paskutini nari paraso i console ir poto isema
            //Console.WriteLine(myStack.Pop());   //paskutinis narys jau kitas rodomas ir irgi isemamas



            Queue<string> numbers = new Queue<string>();

            numbers.Enqueue("one");     //deda i eiles pradzia
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            //Console.WriteLine(numbers.Dequeue());       //rodo nuo pirmo eiles tvarka, one, two.. tai rodys one

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");     //txt yra key notepad.exe yra value 
            openWith.Add("bmp", "paint.exe");       // jie kaip listai, bet gali laikyt 2 parametrus?
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //foreach(var item in openWith)
            //{
            //    Console.WriteLine(item.Key+" "+ item.Value);
            //}

            IList<string> myStrings = new List<string>();

            myStrings.Add("aurimas");
            myStrings.Add("mindaugas");
            myStrings.Add("marius");
            myStrings.Add("tomas");
            myStrings.Add("jurgis");
            myStrings.Add("matas");


            //string manoVardai = myStrings.Where(x => x == "aurimas").FirstOrDefault();

            IList<string> manoVardai = myStrings.Where(x => x == "aurimas").ToList();

            manoVardai.Add("aurimas");
            //Console.WriteLine(manoVardai.Count());


            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 },
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2 },
                new Student() { StudentID = 5, StudentName = "Ron", Age = 21}
            };

            IList<Student> studentsOver18 = studentList.Where(x => x.Age > 18).ToList();
            IList<Student> studentID5 = studentList.Where(x => x.StudentID == 5).ToList();

            Student penktasStudentas= studentList.FirstOrDefault(x=> x.StudentID==5);       //ras pirma su ID 5 arba mes null reiksme, nes naudojamas FirstOrDefault, jei naudociau First ir nerastu reiksmes tai uzluztu

            foreach(var item in studentsOver18)
            {
                Console.WriteLine(item.StudentName);
            }
            
            if(penktasStudentas != null)
            {
                Console.WriteLine(penktasStudentas.StudentName);
            }

            Console.WriteLine(studentList[3].StudentName); // studentList 3 index vardas
        }
    }
}
