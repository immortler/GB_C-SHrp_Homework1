/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter first number:");
string frstStr = Console.ReadLine();
Console.WriteLine("Enter second number:");
string scndStr = Console.ReadLine();

double frst = Convert.ToDouble(frstStr);
double scnd = Convert.ToDouble(scndStr);

if (frst == scnd)
{
    Console.WriteLine($"{frst} is equal to {scnd}.");
}
else 
{
    if (frst < scnd)
    {
        Console.WriteLine($"{frst} is a smaller number, {scnd} is a larger number.");
    }
    else
    {
        Console.WriteLine($"{scnd} is a smaller number, {frst} is a larger number.");
    }
}