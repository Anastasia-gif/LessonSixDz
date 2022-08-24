/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

System.Console.WriteLine("Введите количество цифр которые будите вводить");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] EnterUserNumber(){
   int [] numbersUser = new int[lengthArray]; 

Console.WriteLine("Начинайте вводить числа, каждое число с новой строки");

   for(int i = 0; i < numbersUser.Length; i++){
    numbersUser[i] = Convert.ToInt32(Console.ReadLine());
   }

   return numbersUser;
}

int Checked ( int [] numbersUser){
      int count = 0;
      for(int i = 0; i < numbersUser.Length; i++){
        if(numbersUser[i] > 0){
            count++;
        }
      }
      return count;
}
int count = Checked(EnterUserNumber());

Console.WriteLine($"Количество чисел > 0 = {count}, ввёл пользователь"); 

