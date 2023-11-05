//Створіть клас «Кафе» з інформацією про працівників кафе.
//Реалізуйте підтримку ітератора для класу «Кафе».
//Протестуйте можливість використання foreach для «Кафе».

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_7
{
    internal class Cafe
    {
        public string? Name_cafe {  get; set; }

        List<Workers> workers = new List<Workers>();

        public void Add(Workers work)
        {
            workers.Add(work);
        }
        public void Print()
        {
            foreach (Workers worker in workers)
            {
                Console.WriteLine($"Працівник {worker.Full_name}\t Посада {worker.Position}");
            }
        }
    }
}
