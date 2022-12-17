Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());


int SumNatural(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNatural(M, N - 1); // Если M<N
    else return N + SumNatural(M, N + 1);            // Если M>N
}
Console.WriteLine($"Сумма натур. элементов = {SumNatural(M, N)}");