// using System;
//
// int[] numbers = new int[10];
// Random random = new Random();
// int count = 0;
//
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = random.Next(-5, 10);
//     Console.WriteLine(numbers[i]);
//     if (numbers[i] == 0)
//     {
//         count++;
//     }
// }
// //Console.WriteLine(count);
// int sum = 0;
// int min = 1;
// int minIndex = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < numbers[minIndex])
//     {
//         minIndex=i;
//         
//     }
// }
//
// for (int i = minIndex; i < numbers.Length; i++)
// {
//     sum += numbers[i];
// }
//
// Console.WriteLine(minIndex);
// Console.WriteLine(sum);


using System;

public class MatrixRotation
{
    public static void RotateMatrix(int[,] matrix, int k)
    {
        int M = matrix.GetLength(0);
        int N = matrix.GetLength(1);

        // Вычисляем количество полных оборотов
        int fullRotations = k % (M * N);

        for (int rotation = 0; rotation < fullRotations; rotation++)
        {
            // Сдвигаем элементы вправо на один шаг
            for (int i = 0; i < M; i++)
            {
                for (int j = N - 1; j > 0; j--)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int k = 2; // Количество элементов для сдвига

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        RotateMatrix(matrix, k);

        Console.WriteLine("\nМатрица после циклического сдвига на " + k + " элементов вправо:");
        PrintMatrix(matrix);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int M = matrix.GetLength(0);
        int N = matrix.GetLength(1);

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}