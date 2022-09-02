/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9

*/

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Идёт выполнение программы: ");

int step = 0;
int CalculatingAckermanFunction(int m, int n)
{
    step++;

    if (m == 0) return n + 1;
    if (n == 0) return CalculatingAckermanFunction(m - 1, 1);
    return CalculatingAckermanFunction(m - 1, CalculatingAckermanFunction(m, n - 1));

}

Console.WriteLine(CalculatingAckermanFunction(m,n));