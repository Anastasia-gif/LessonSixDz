/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

int[,,] CreateMatrix(int x, int y, int z)
{
    int[,,] matrix3D = new int[x, y, z];
    int i = 10;
    for (int ix = 0; ix < x; ix++)
    {
        for (int iy = 0; iy < y; iy++)
        {
            for (int iz = 0; iz < z; iz++)
            {
                matrix3D[ix, iy, iz] = i++;
            }
        }
    }
    return matrix3D;
}

void PrintMatrix(int[,,] matrix3D)
{
    for (int iz = 0; iz < matrix3D.GetLength(2); iz++)

    {
        for (int ix = 0; ix < matrix3D.GetLength(0); ix++)

        {

            for (int iy = 0; iy < matrix3D.GetLength(1); iy++)
            {
                Console.Write($"{matrix3D[ix, iy, iz]}({ix},{iy},{iz}) \t");
            }
            Console.WriteLine();
        }
    }
}

var matrix3D = CreateMatrix(x, y, z);

PrintMatrix(matrix3D);