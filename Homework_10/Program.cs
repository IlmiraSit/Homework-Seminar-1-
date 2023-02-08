//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Kratno");
}
else if (b % a == 0)
{
    Console.WriteLine("Kratno");
}
else
{
    Console.WriteLine("Not");
}

