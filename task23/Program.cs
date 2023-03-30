/*** Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
int i = 0;
for (i = 1; i<=n ; i++)
{
  numbers [i-1] = i*i*i;
}
Console.Write($"{n} -> ");
for (i = 0; i<n ; i++)
Console.Write($"{numbers[i]} ");
