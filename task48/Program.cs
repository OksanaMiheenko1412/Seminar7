// task48 Задайте двумерный массив размера m на n, каждый элемент в массиве
//находится по формуле: Amn = m + n. Выведите полученный массив на экран
// m=3, n=4. 0123;1234;2345.
 void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);