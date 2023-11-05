//Створіть клас «Кафе» з інформацією про працівників кафе.
//Реалізуйте підтримку ітератора для класу «Кафе».
//Протестуйте можливість використання foreach для «Кафе».

using NET_Homework_7_7;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Cafe cafe = new Cafe();
cafe.Name_cafe = "Premium";

cafe.Add(new Workers() { Full_name = "Калмикова Наталія Фернандівна", Position = "директор" });
cafe.Add(new Workers() { Full_name = "Терефенко Ольга Романівна", Position = "повар" });
cafe.Add(new Workers() { Full_name = "Тимченко Тетяна Іванівна", Position = "кондитер" });
cafe.Add(new Workers() { Full_name = "Філіпович Тетяна Володимирівна", Position = "офіціант" });
cafe.Add(new Workers() { Full_name = "Юзбекова Ольга Андріївна", Position = "офіціант" });

Console.WriteLine($"Кафе \"{cafe.Name_cafe}\"\nПрацівники:");

cafe.Print();