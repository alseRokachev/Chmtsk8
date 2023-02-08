// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] fillArray(int y, int x, int z)
{
    int[,,] array = new int[y, x, z];
    Random rand = new Random();
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int n = 0; n < z; n++)
            {
                array[i, j, n] = rand.Next(10, 20);
            }
        }

    }
    return array;
}

void makeArrayUnique(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }

}

void printArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int n = 0; n < array3D.GetLength(2); n++)
            {
                System.Console.WriteLine($"{array3D[i, j, n]} ===> X = {j}, Y = {i}, Z = {n}");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}



int[,,] array3D = fillArray(2, 2, 2);
makeArrayUnique(array3D);
printArray(array3D);