// task1 введение массива строк

//Console.Clear();
//string[] numbers = Console.ReadLine().Split(" ");
//foreach (string i in numbers)// перебор массива без использования нумерации и
//{
   // Console.WriteLine(i); // вывод в терминале каждое число с новой строки
//}
// функция Split - противоположна void, разделяет строку

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int row = int.Parse(numbers[0]);//количество строк
int col = int.Parse(numbers[1]);//количество столбцов
int[,] matrix = new int[row, col];