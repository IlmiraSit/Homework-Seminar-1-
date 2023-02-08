Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
int sum=b*b;
if (sum!=a)
{
    Console.WriteLine("Не является:"+sum);
}
else if (sum==a)
{
    Console.WriteLine("Является квадратом:"+sum);
}


