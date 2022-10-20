// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("M = ");
int m = int.Parse(Console.ReadLine());

Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {Summ(m, n)}");

int Summ(int m, int n)
{
    if (m == n) 
        return n;
    else 
        return Summ (m, n - 1) + n;
}
