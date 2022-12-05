namespace OOPTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group(1, "651.20");
            Group group2 = new Group(2, "655.20");
            Student student1 = new Student(1, "Rauf", "Ehmedli");
            Student student2 = new Student(2, "Ferid", "Adgozelov");
            Student student3 = new Student(3, "Huseyn", "Huseynov");
            Student student4 = new Student(4, "Araz", "Merdanov");

            group1.AddStudent(student1);
            group2.AddStudent(student2);
            group2.AddStudent(student3);
            group2.AddStudent(student4);
            group2.RemoveStudent(student4);
            group2.GetStudents();



        }

    }
}