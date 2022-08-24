// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите первый отрезок");

double pointB1 = Convert.ToInt32(Console.ReadLine());
double pointK1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второй отрезок");
double pointB2 = Convert.ToInt32(Console.ReadLine());
double pointK2 = Convert.ToInt32(Console.ReadLine());


void findingIntersectionPoint(double k1, double b1, double k2, double b2)
{   
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"X = {x} Y = {y}");
}
findingIntersectionPoint(pointK1,pointB1,pointK2,pointB2);


