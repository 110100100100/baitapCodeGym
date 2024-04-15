using System;

class Program
{
    static void Main()
    {
        // Bước 1: Tính tổng các phần tử của một ma trận vuông có sẵn
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        CalculateMatrixSum(matrix);

        // Bước 2: Thu thập mảng từ người dùng và hoàn thành yêu cầu
        Console.WriteLine("Nhập kích thước của ma trận vuông:");
        Console.Write("Kích thước: ");
        int size = int.Parse(Console.ReadLine());

        int[,] userMatrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Nhập giá trị của phần tử [{i},{j}]: ");
                userMatrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        CalculateMatrixSum(userMatrix);
    }

    // Phương thức tính tổng các phần tử của một ma trận
    static void CalculateMatrixSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine($"Tổng các phần tử của ma trận là {sum}.");
    }
}

