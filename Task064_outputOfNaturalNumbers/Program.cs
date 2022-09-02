/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Идёт выполнение программы: ");

if(M > N ) {
    Console.WriteLine("Первое число не может быть больше второго");
    return;
} 
if(M == 0){
   Console.WriteLine("0 это не натуральное число");
   return;
}
void OutputNaturalNumbers(int m, int n){
    Console.WriteLine(m); 
    if(m == n) return;
    OutputNaturalNumbers(m + 1, n);
     
}

OutputNaturalNumbers(M,N);