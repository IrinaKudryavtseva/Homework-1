Console.Write("a = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
   Console.Write("Max = ");
   Console.Write(number1);
}
else if(number2 > number1)
{
   Console.Write("Max = ");
   Console.Write(number2);
}
else
{
   Console.WriteLine("Числа равны между собой");
}
