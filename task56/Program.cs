// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размерность думерного массива r x c. ");
Console.WriteLine("Введите r: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix1 = FillMatrix(r, c);
PrintMatrix(Matrix1);
Console.WriteLine();

int Sum = 0;
int[] SumResult = new int[r];

for (int i = 0; i < Matrix1.GetLength(0); i++)
{
    for (int j = 0; j < Matrix1.GetLength(1); j++)
    {

        Sum += Matrix1[i, j];
    }
    Console.WriteLine(Sum);
    SumResult[i] = Sum;
    Sum = 0;
}

// Console.WriteLine();
// Console.WriteLine(String.Join(",", SumResult));
// Console.WriteLine();

int minVal = SumResult.Min();
int indexMin = Array.IndexOf(SumResult, minVal);

// Console.WriteLine(minVal);

Console.WriteLine("Минимальная сумма элементов массива находится в строке №"+indexMin+1+".");