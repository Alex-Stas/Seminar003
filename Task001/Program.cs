// ************************************************
// Поиск третьего числа через массив

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
if (i < array.Length - 1)
Console.Write(", ");
else
Console.Write(".");
}
}

int num = int.Parse(Console.ReadLine());
int temp = num;

int count = 0;
while (temp != 0)
{
temp = temp / 10; // num /= 10;
count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--) // в обратном напралении поскольку деление дает остаток с конца
{
array[i] = num % 10;
num /= 10; // аналог num = num / 10
}

PrintArray(array);

Console.Write($"\n{array[2]}");


// **************************************************************************
// Ввод любого количества переменных.

// int[] InputSomeNumbers()
// {
//     Console.Write("Enter quantity of numbers: ");
//     int size = int.Parse(Console.ReadLine()!);

//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Enter {i + 1} number: ");
//         array[i] = int.Parse(Console.ReadLine()!);




//     }
        
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//         else
//             Console.Write("."); 
//     }
// }

// int[] myArray = InputSomeNumbers();
// PrintArray(myArray);


// ******************************************************
// Ввод двух значений

// int[] InputSomeNumbers()
// {
//     int[] twoNums = new int[2];
//     Console.Write("Enter first number: ");
//     twoNums[0] = int.Parse(Console.ReadLine()!);
//     Console.Write("Enter second number: ");
//     twoNums[1] = int.Parse(Console.ReadLine()!);
//     return twoNums;
// }

// int[] array = InputSomeNumbers();
// Console.WriteLine($"First {array[0]}, second {array[1]}");

