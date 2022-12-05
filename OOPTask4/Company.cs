using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask4
{
    internal class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }

        Worker[] workers = { };

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length + 1);
            workers[workers.Length - 1] = worker;
        }
        public void RemoveWorker(Worker worker)
        {
            Worker[] newWorkers = { };
            foreach (Worker wor in workers)
            {
                if (!worker.Equals(wor))
                {
                    Array.Resize(ref newWorkers, newWorkers.Length+1);
                    newWorkers[newWorkers.Length - 1] = wor;
                }
            }
            workers = newWorkers;
        }

        public void GetWorkers()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.GetFullInfo());
            }
        }
    }
}

