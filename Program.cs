using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

int i = 0;
Console.WriteLine("Задание 'Операции с большими числами' на оценку 3.");
Console.Write("Введите число: ");
string megaNum = Console.ReadLine();
List<int> list = new List<int>();

foreach (char n in megaNum) { list.Add(Convert.ToInt32(n.ToString())); i++; };
foreach (int n in list) { Console.Write(n + " "); }

int[] array = new int[i];
list.CopyTo(array);

Console.WriteLine($"\nСумма цифр числа = {array.Sum()}");

Console.WriteLine("\nЖми --> ENTER <--");
Console.ReadLine();
Console.Clear();


double g = 1;
foreach (int n in array) { g *= n; };

Console.Write("Что бы увидеть произведение всех цифр при умножении нажмите --> ENTER...");
Console.ReadLine();

Console.WriteLine($"\nПроизведение всех цифр при умножении = {g}");
Console.Write("Макс-Мин значение цифр из числа тоже --> ENTER <-- xD");
Console.ReadLine();

Console.WriteLine($"\nМаксимальное значение цифры = {array.Max()}");
Console.WriteLine($"\nМинимальное значение цифры = {array.Min()}");

Console.WriteLine("задание на оценку 4");

int i1 = 0;
string megaNum1 = "1";
List<int> list1 = new List<int>();

foreach (char n in megaNum1) { list1.Add(Convert.ToInt32(n.ToString())); i1++; };

int[] bufer1 = new int[i1];

list1.CopyTo(bufer1);

//раздел

int i2 = 0;
string megaNum2 = "99";
List<int> list2 = new List<int>();

foreach (char n in megaNum2) { list2.Add(Convert.ToInt32(n.ToString())); i2++; };

int[] bufer2 = new int[i2];

list2.CopyTo(bufer2);
int k = 0;

int g1 = i1;
int g2 = i2;
if (i1 > i2) {k = i1 + 1; g2 += 1; } else {k = i2 + 1; g1 += 1; };

int[] mas = new int[k];

Console.WriteLine("--> ENTER");
Console.ReadLine();
Console.WriteLine("конец xD");

for (i = 0; i < k - 1; i++ )  { g1--; g2--; mas[i] = bufer1[g1] + bufer2[g2]; if (mas[i] > 9) { mas[i] -= 10; mas[i + 1] += 1;  } };

foreach (int n in mas) { Console.Write(n); }
