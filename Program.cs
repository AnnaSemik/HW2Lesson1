int max=1;
Console.WriteLine ("Введите первое число");
string num1=Console.ReadLine();
int number1=int.Parse(num1);
Console.WriteLine ("Введите второе число");
string num2=Console.ReadLine();
int number2=int.Parse(num2);
Console.WriteLine ("Введите третье число");
string num3=Console.ReadLine();
int number3=int.Parse(num3);
if (number1>number2) max=number1;
else max=number2;
if (max<number3) max=number3;
Console.Write ("Максимальное число "+max);


