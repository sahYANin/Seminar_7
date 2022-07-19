/*
    Задача 50. 
    Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
*/

int[,] Matr(int n, int m, int a, int p)
{
    int[,] Matrix = new int[n, m];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int s = 0; s < Matrix.GetLength(1); s++)
        {
            Matrix[i, s] = new Random().Next(0, 100);
            if (a == Matrix[i, s]) p++;

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
Console.Write("Какое хотите найти число: ");
int a = Convert.ToInt16(Console.ReadLine());
int p = 0;

Matr(n, m, a, p);
if (p == 0) Console.WriteLine(a + " <=   такого числа в массиве, нет");
else Console.WriteLine(a + " <=   такое число в массиве, присутствует ");
