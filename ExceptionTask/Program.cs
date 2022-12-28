using System.Net.Mail;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Rauf Ehmedli");
            User user2 = new User("Araz Merdanov");
            User user3 = new User("Ferid Adgozelov");
            User user4 = new User("Sadiq Aliyev");
            Console.WriteLine(user4._id);

            try
            {
                user.Email = "rauf20032015@gmail.com";
                MailAddress address = new MailAddress(user.Email);
            }
            catch (FormatException)
            {
                user.Email = "";
                Console.WriteLine("Mail duzgun formatda deyil");
            }
            Console.WriteLine(user.Email);
        }
    }
}