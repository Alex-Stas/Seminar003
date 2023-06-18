int[] InputSomeNumbers()
{
    int[] twoNums = new int[2];
    Console.Write("Enter first number: ");
    twoNums[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    twoNums[1] = int.Parse(Console.ReadLine()!);
    return twoNums;
}

int[] array = InputSomeNumbers();
Console.WriteLine($"First {array[0]}, second {array[1]}");

