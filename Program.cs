//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Определите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Определите количество столбцов");
int n = int.Parse(Console.ReadLine());
void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr [i,j] = new Random().Next(-10,11);
        }
    }
}
void PrintArray(double[,] matr)

{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {            
            Console.Write($"{matr[i,j]} ");
        }
    }           
}
double [,] matr = new double[m,n];
FillArray(matr);
PrintArray(matr);




// Напишите программу, которая проверяет наличие указанного значения элемента в двумерном массиве или же указание, что такого элемента нет.
Console.WriteLine("Определите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Определите количество столбцов");
int n = int.Parse(Console.ReadLine());
void FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr [i,j] = new Random().Next(0,101);
        }
    }
}
void PrintArray(int[,] matr)

{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {            
            Console.Write($"{matr[i,j]} ");
        }
    }           
}
int [,] matr = new int[m,n];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Задайте число");
int a = int.Parse(Console.ReadLine());
int b = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == a)
            {
                b = 1;                           
            }
              
        }
    }
if (b == 1)
{
    Console.WriteLine("Это число есть в массиве");
}
else 
{
    Console.WriteLine("Этого числа нет в массиве");
}   