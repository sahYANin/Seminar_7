/*
    Задача 47. 
    Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/
double[,] Matr(int n, int m)
{
    double[,] Matrix = new double[n, m];
    Random rand = new Random();
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int s = 0; s < Matrix.GetLength(1); s++)
        {
            Matrix[i, s] = rand.NextDouble()*10;
            Console.Write(Matrix[i, s] + " ");
        }
        Console.WriteLine();
    }
    return Matrix;
}

Console.Write("Введите число для n матрицы: ");
int n = Convert.ToUInt16(Console.ReadLine());
Console.Write("Введите число для m матрицы: ");
int m = Convert.ToInt16(Console.ReadLine());
Matr(n, m);