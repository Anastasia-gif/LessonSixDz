/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

int size = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int stepX = 1;
    int stepY = 0;
    int value = 1;
    int x = 0;
    int y = 0;
    int sizeStep = 0;
    for (int i = 0; i < size * 2 - 1; i++)
    {

        for (int ii = 0; ii < size - sizeStep; ii++)
        {
            if (x < 0 || y < 0 || x >= size || y >= size) return matrix;
            matrix[x, y] = value++;
            if (ii == size - sizeStep - 1)
            {
                int t = stepX;
                stepX = -stepY;
                stepY = t;
            }
            x += stepX;
            y += stepY;
        }
        if ((i) % 2 == 0) sizeStep++;

    }
    return matrix;
}

var matrix = CreateMatrix(size);
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(matrix[j, i] + "\t");
    }
    Console.WriteLine();
}