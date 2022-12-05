using OOPTask2.Class;

namespace OOPTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Ferid", "Adgozelov");
            Student student = new Student(2,"Araz","Merdanov","655.20");
            Teacher teacher = new Teacher(3,"Sadiq","Aliyev","BackEnd Developer");
            Console.WriteLine(person.GetFullInfo());
            Console.WriteLine(student.GetFullInfo());
            Console.WriteLine(teacher.GetFullInfo());
            student.Ilearn();
            teacher.Iteach();


        }
    }
}