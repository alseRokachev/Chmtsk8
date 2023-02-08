// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] sortArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int n = 0; n < array2D.GetLength(1) - 1; n++)
            {
                if (array2D[i, j] > array2D[i,n])
                {
                    int temp = array2D[i,j];
                    array2D[i,j] = array2D[i, n];
                    array2D[i, n] = temp;
                }
            }
        }
    }
    return array2D;
}


int rows = numbCheck("Введите кол-во строк массива: ");
int cols = numbCheck("Введите кол-во столбцов массива: ");

int[,] array2D = fillArray(rows, cols);
System.Console.WriteLine("Исходный массив: ");
printArray(array2D);

int[,] sortedArray2D = sortArray(array2D);
System.Console.WriteLine("Отсортированный массив: ");
printArray(sortedArray2D);