int InputNum (string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int Quart (int x, int y)
{
if (x > 0 && y > 0) return 1;
else if (x < 0 && y > 0) return 2;
else if (x < 0 && y < 0) return 3;
else if (x > 0 && y < 0) return 4;
else return -1;
}

int x = InputNum("Введите координату х: ");
int y = InputNum("Введите координату y: ");

int res = Quart(x, y);

if (res == - 1)
Console.WriteLine("Точка находится на пересечении четвертей");
else
Console.WriteLine($"Четверть {res}");
