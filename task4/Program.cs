Console.WriteLine("Введите три числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1) max = number2;
if (number3 > max) max = number3;
Console.WriteLine(max);

