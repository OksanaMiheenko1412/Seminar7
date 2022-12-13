// task49 Задайте двумерный массив.Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты. Пример: изначальный массив 1472, 5923,
// 8424. Новый массив 1472, 5 81 2 9, 8424
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);//заполнение массива случайным
            // образом от 1 до 10
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                matrix[i, j] *= matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers  = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Результат: ");
ReleaseMatrix(matrix);