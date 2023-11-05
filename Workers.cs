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
    internal class Workers:Cafe
    {
        public string? Full_name {  get; set; }
        public string? Position { get; set; }
    }
}
