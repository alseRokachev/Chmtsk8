// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] createArray()
{
    Random rand = new Random();
    int[,] array = new int[4, 4];
    int counter = rand.Next(0,50);
    for (int i = 0; i < 4; i++)
    {
        array[0, i] = counter++;
    }
    for (int i = 1; i < 3; i++)
    {
        array[i, 3] = counter++;
    }
    for (int i = 3; i >= 0; i--)
    {
        array[3, i] = counter++;
    }
    for (int i = 0; i < 1; i++)
    {
        array[2, i] = counter++; ;
    }
    for (int i = 0; i < 3; i++)
    {
        array[1, i] = counter++;
    }
    for (int i = 2; i > 0; i--)
    {
        array[2, i] = counter++;
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

int[,] array2D = createArray();
printArray(array2D);

