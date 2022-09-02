/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if(M > N ) {
    Console.WriteLine("Первое число не может быть больше второго");
    return;
} 

Console.WriteLine("Программа считает: ");

int CalcSumNaturalElements(int m, int n)
{
    if (m == n) return m;
    return m + CalcSumNaturalElements( m + 1, n);
}
Console.WriteLine(CalcSumNaturalElements(M, N));
