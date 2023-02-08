// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int numbCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0)
            {
                break;
            }
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}

int[,] fillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rand.Next(0, 11);
        }

    }
    return array;
}

void printArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] findStringSumOfArray(int[,] array2D)
{
    int[] array = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum = sum + array2D[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void compareSums(int[] sumsArray)
{
    int min = sumsArray[0];
    int counter = 0;
    for (int i = 0; i < sumsArray.Length; i++)
    {
        if (min > sumsArray[i]) {
            min = sumsArray[i];
            counter = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой, равной: {min} -----> {counter + 1} строка");
}


int rows = numbCheck("Введите кол-во строк массива: ");
int cols = numbCheck("Введите кол-во столбцов массива: ");

int[,] array2D = fillArray(rows, cols);
System.Console.WriteLine("Исходный массив: ");
printArray(array2D);

int[] sumsArray = findStringSumOfArray(array2D);
compareSums(sumsArray);