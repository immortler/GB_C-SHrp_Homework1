/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter integer number:");
string nmbrStr = Console.ReadLine();

int nmbr = Convert.ToInt32(nmbrStr);

Console.WriteLine(nmbr);

if (Math.Abs(nmbr % 2) == 1)
{
    Console.WriteLine($"{nmbr} is an odd number (nechetnoe).");
}
else
{
    Console.WriteLine($"{nmbr} is an even number (chetnoe).");
}