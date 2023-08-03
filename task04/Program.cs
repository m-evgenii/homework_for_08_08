Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
int index = 0;
while(index<number){
    if(result % 2 == 0){
        Console.WriteLine(result);

    }
    result++;
    index++;
}

