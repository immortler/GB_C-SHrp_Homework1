/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter first number:");
string frstStr = Console.ReadLine();
Console.WriteLine("Enter second number:");
string scndStr = Console.ReadLine();
Console.WriteLine("Enter third number:");
string thrdStr = Console.ReadLine();

double frst = Convert.ToDouble(frstStr);
double scnd = Convert.ToDouble(scndStr);
double thrd = Convert.ToDouble(thrdStr);

double max = frst;

if (max < scnd)
{
    max = scnd;
}
else if (max < thrd)
{
    max = thrd;
}

Console.WriteLine($"Maximal number is {max}");