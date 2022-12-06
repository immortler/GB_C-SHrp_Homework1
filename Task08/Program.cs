/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Enter a number more than 1:");
string nmbrStr = Console.ReadLine();

int nmbr = Convert.ToInt32(nmbrStr);

if (nmbr < 2)
{
Console.WriteLine("Error: wrong number.");
}

else 
{
    for (int i = 1; i <= nmbr; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}