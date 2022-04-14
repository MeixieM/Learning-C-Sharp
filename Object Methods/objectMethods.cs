using System;

namespace Object_Methods
{
    class objectMethods
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Carlo", "Art", 2.8);
            Student student2 = new Student("Ana", "Business", 3.8);

            Console.WriteLine(student1.StudentHasHonors());
            Console.WriteLine(student2.StudentHasHonors());

            Console.ReadKey();
        }
    }
}
