// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            matrix[i, j] = new Random().Next(1, 100);
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

for (int i = 0; i < Matrix1.GetLength(0); i++)
{

    for (int j = 0; j < Matrix1.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < Matrix1.GetLength(1) - 1; k++)
        {
            if (Matrix1[i, k + 1] > Matrix1[i, k])
            {
                int temp = Matrix1[i, k];
                Matrix1[i, k] = Matrix1[i, k + 1];
                Matrix1[i, k + 1] = temp;
            }
        }
    }
    Console.WriteLine();
}

// for (int i = 0; i < Matrix1.GetLength(0); i++)
// {

//     for (int j = 0; j < Matrix1.GetLength(1) - 1; j++)
//     {

//         for (int k = j + 1; k < Matrix1.GetLength(1); k++)
//         {
//             if (Matrix1[i, k] > Matrix1[i, j])
//             {
//                 int temp = Matrix1[i, j];
//                 Matrix1[i, j] = Matrix1[i, k];
//                 Matrix1[i, k] = temp;
//             }
//         }
//     }

//     Console.WriteLine();
// }

PrintMatrix(Matrix1);