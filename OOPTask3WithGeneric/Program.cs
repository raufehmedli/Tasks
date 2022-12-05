namespace OOPTask3WithGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(1, "Huseyn");
            Student student2 = new Student(2, "Ferid");
            Group group = new Group(1, "BBA012");
            List<Group> groups=new List<Group>();
            groups.Add(student1);

        }
    }
}