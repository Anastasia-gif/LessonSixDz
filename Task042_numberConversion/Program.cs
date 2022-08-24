//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
System.Console.WriteLine("Введите целое десятичное число для преобразования его в двоичное. PS.если у вас не целое число , то понадобятся совсем другие вычисления");
int enterDecimalNumber = Convert.ToInt32(Console.ReadLine());
   

List<int> convertingNumberToDouble(int decimalNumber){
    List<int> binaryNumber = new List<int>();

    while(decimalNumber > 0){
     binaryNumber.Add(decimalNumber % 2);
     decimalNumber /= 2;
    }
    
    for (int i = 0; i < binaryNumber.Count / 2; i++){
        int temp = binaryNumber[i];
        binaryNumber[i] = binaryNumber[binaryNumber.Count-1-i];
        binaryNumber[binaryNumber.Count-1-i] = temp;
    }
    return binaryNumber;
}

foreach(int i in convertingNumberToDouble(enterDecimalNumber)){
    Console.Write(i);
}

