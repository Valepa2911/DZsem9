//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Ведите число: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число: n");
int n = Convert.ToInt32(Console.ReadLine());

int SumNatural(int m, int n)
{
    if (m > n) return 0; 
    {
         return n + SumNatural(m, n - 1);
    }
   
}

Console.WriteLine(SumNatural(m, n));
