Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(number1>number2){
    max = number1;
    min = number2;
}
else{
    max = number2;
    min = number1;
}
Console.WriteLine("Наибольшее число");
Console.WriteLine(max);
Console.WriteLine("Наименьшее число");
Console.WriteLine(min);