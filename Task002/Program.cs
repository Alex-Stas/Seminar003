
// **************************************************
// Второй вариант программы, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

int InputNum(string message)
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

void PrintSquary(int num)
{
for (int i = 1; i <= num; i++)
{
Console.Write(i * i);
if (i < num)
Console.Write(", ");
else
Console.Write(".");
}
}
PrintSquary (InputNum("Enter desired number please: "));



// **************************************************
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// int InputNum(string message)
// {
// Console.Write(message);
// int num = int.Parse(Console.ReadLine()!);
// return num;
// }

// int[] FillArraySquares(int num)
// {
//     int[] array = new int[num];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Math.Pow((i + 1), 2));
//         // array[i] = Convert.ToInt32(Math.Round(Math.Sqrt(i + 1), 0)); - это корень big mistake
//         // array[i] = (i + 1) * (i + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]);
// if (i < array.Length - 1)
// Console.Write(", ");
// else
// Console.Write(".");
// }
// }
// int num = InputNum("Enter desired number please: ");
// PrintArray(FillArraySquares(num));



// **********************************************
// Задача с расстоянием между точками


// int InputNum(string message)
// {
// Console.Write(message);
// int num = int.Parse(Console.ReadLine()!);
// return num;
// }
// int xA = InputNum("entre x point A: ");
// int yA = InputNum("entre y point A: ");
// int xB = InputNum("entre x point B: ");
// int yB = InputNum("entre y point B: ");

// double Root(int xA, int yA, int xB, int yB)
// {
// double res1 = Math.Pow(xB - xA, 2);
// double res2 = Math.Pow(yB - yA, 2);
// double res = Math.Sqrt(res1 + res2);
// return res;
// }

// double distance = Root(xA, yA, xB, yB);
// //Console.Write(distance);
// Console.WriteLine(Math.Round(distance, 2));



// ********************************************
// Задача с квадрантами

// int InputNum (string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int Quart (int x, int y)
// {
// if (x > 0 && y > 0) return 1;
// else if (x < 0 && y > 0) return 2;
// else if (x < 0 && y < 0) return 3;
// else if (x > 0 && y < 0) return 4;
// else return -1;
// }

// int x = InputNum("Введите координату х: ");
// int y = InputNum("Введите координату y: ");

// int res = Quart(x, y);

// if (res == - 1)
// Console.WriteLine("Точка находится на пересечении четвертей");
// else
// Console.WriteLine($"Четверть {res}");
