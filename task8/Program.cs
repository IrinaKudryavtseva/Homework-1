//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
int number = new Random().Next(1,20);
Console.WriteLine("N = " + number);
for (int N = 1; N <= number; N++)
if (N % 2 == 0)
{
Console.Write(N + " ");
}

