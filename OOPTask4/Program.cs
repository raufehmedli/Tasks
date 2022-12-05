using System.Text.RegularExpressions;

namespace OOPTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company group1 = new Company(1, "Premium BackEnd developers");
            Company group2 = new Company(2, "BackEnd developers");
            Worker worker1 = new Worker(1, "Sadiq", "Aliyev", 2800);
            Worker worker2 = new Worker(2, "Rauf", "Ehmedli",1800);
            Worker worker3 = new Worker(3, "Ferid", "Adgozelov",1000);
            Worker worker4 = new Worker(4, "Huseyn", "Huseynov",1000);
            Worker worker5 = new Worker(5, "Araz", "Merdanov",1000);

            group1.AddWorker(worker1);
            group1.AddWorker(worker2);
            group2.AddWorker(worker3);
            group2.AddWorker(worker4);
            group2.AddWorker(worker5);
            group1.GetWorkers();
            group2.RemoveWorker(worker3);
            group1.AddWorker(worker3);
            group2.GetWorkers();

        }
    }
}