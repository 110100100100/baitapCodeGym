using System.ComponentModel.DataAnnotations;

int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
FindLargestElement(matrix);

Console.WriteLine("Nhập kích thước của ma trận:");
Console.Write("Số hàng: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Số cột: ");
int cols = int.Parse(Console.ReadLine());

int[,] userMatrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"Nhập giá trị của phần tử [{i},{j}]: ");
        userMatrix[i, j] = int.Parse(Console.ReadLine());
    }
}

FindLargestElement(userMatrix);

static void FindLargestElement(int[,] matrix)
{
    int maxElement = matrix[0, 0];
    int maxRow = 0;
    int maxCol = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maxElement)
            {
                maxElement = matrix[i, j];
                maxRow = i;
                maxCol = j;
            }
        }
    }
}

Console.WriteLine($"Phần tử lớn nhất của ma trận là {maxElement} tại vị trí [{maxRow},{maxCol}].");