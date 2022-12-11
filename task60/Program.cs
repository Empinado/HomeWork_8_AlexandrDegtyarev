// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размерность думерного массива r x c x b. ");
Console.WriteLine("Введите r: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

//Создаем метод, который будет проверять повторения элемента в массиве. И передавать результат в условие заполнения массива. Чтобы избежать повторений.
bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

int[,,] FillMatrix(int rows, int columns, int b)
{
    int min = 10;
    int max = 99;
    int[,,] matrix = new int[rows, columns, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = 0;
            while (k < matrix.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(matrix, element)) continue;
                matrix[i, j, k] = element;
                k++;
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}); ");
            }

        }
        Console.WriteLine();
    }
}

int[,,] Matrix1 = FillMatrix(r, c, b);
PrintMatrix(Matrix1);
Console.WriteLine();



