/*
    Задача 52. 
    Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/
int[,] Matr(int n, int m)
{
    int[,] Matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int s = 0; s < m; s++)
        {
            Matrix[i, s] = new Random().Next(0, 11);
            Console.Write(Matrix[i, s] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return Matrix;
}

void AverageMatr(int[,] Matrix, int n, int m)
{
    int q=0;        // костыль 
    if (n < m)q++;  // костыль 
    else n=m;       // костыль 
    double[] x = new double[m];
    for (int i = 0; i < n; i++)
    {
        for (int s = 0; s < m; s++)
        {
            x[s] = x[s] + Matrix[i, s];
            // Console.Write(x[s] + " ");
        }
        //  Console.WriteLine();
    }
    // Console.WriteLine();
    for(int i = 0; i < m; i++){
        x[i]=x[i]/m;
    Console.Write(x[i] + " ");
    }
}

// Console.Write("Введите число для n матрицы: ");
int n = 2;
// Console.Write("Введите число для m матрицы: ");
int m = 3;



AverageMatr(Matr(n, m), n, m);








/*

void AverageMatr(int[,] Matrix, int n, int m)
{
    int[] x = new int[n];
    for (int i = 0; i < n; i++)
    {
        for (int s = 0; s < m; s++)
        {
            x[i] = x[i] + Matrix[i, s];
            Console.Write(x[i] + " ");
        }
        Console.WriteLine();
    }

    // for (int i = 0; i < Matrix.GetLength(0); i++)
    // {
    //     Matrix[n, i] = Matrix[n, i] / n;
    //     Console.Write(Matrix[n, i] + " ");
    // }

}


*/