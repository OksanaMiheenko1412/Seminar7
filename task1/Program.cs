// task1 введение чисел в одну строку

//Console.Clear();
//string[] numbers = Console.ReadLine().Split(" "); числа записываются как строка
//foreach (string i in numbers)// перебор массива без использования нумерации 
//{
   // Console.WriteLine(i); // вывод в терминале каждое число в одну строки, удобно
//} для ввода в двумерных массивах (простым языком кажое число с новой строки)
// функция Split - противоположна void, разделяет элементы на массив

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int row = int.Parse(numbers[0]);//количество строк
int col = int.Parse(numbers[1]);//количество столбцов
int[,] matrix = new int[row, col];