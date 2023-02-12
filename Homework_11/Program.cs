//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine() ?? "0");
while(a >= 999)
a = a / 10;
Console.WriteLine($"Third digit: {a % 10}");
if (a <= 999);
 Console.WriteLine("there is no third number");
