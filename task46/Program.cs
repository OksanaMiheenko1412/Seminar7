// task46 Задайте двумерный массив размером m x n, заполненный случайными целыми
// числами. m=3, n=4. 1 4 8 19; 5 -2 33 -2; 77 3 8 1

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);// [-10, 10]
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
//   /t - табуляция используется для расположения в матрице элемента под элементом
//   /n - переход на новую строчку без использования Console.WriteLine