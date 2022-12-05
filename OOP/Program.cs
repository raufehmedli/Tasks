namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Rauf","Ehmedli");
            Console.WriteLine( person1.getfullname());
            Student student1 = new Student("Araz", "Merdanov", "655.20","AA123");
            Console.WriteLine( student1.getfullname());
            //student1.setCardNumber("aaasd345");
            //Console.WriteLine(student1.getCardNumber());
            Student studen2 = new Student("Zaur","Ehmedli","655.20ES","AA345");
            Console.WriteLine(studen2.getfullname());
        }
    }
}