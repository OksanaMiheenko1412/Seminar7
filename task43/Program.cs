// task43 Напишите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y=k1*x+b1, y=k2*x+b2; значения b1,k1,b2,k2 - задаются
//пользователем. b1=2,k1=5,b2=4,k2=9 ->(-0,5; -0,5)
Console.Clear();
Console.Write("Введите k и b первой прямой: ");
string[] numbersFirst =Console.ReadLine().Split(" ");
double k1 = double.Parse(numbersFirst[0]);
double b1 = double.Parse(numbersFirst[1]);
Console.Write("Введите k и b второй прямой: ");
string[] numbersSecond =Console.ReadLine().Split(" ");
double k2 = double.Parse(numbersSecond[0]);
double b2 = double.Parse(numbersSecond[1]);
Console.WriteLine((b2 - b1) / (k1 - k2));
Console.WriteLine(k1 * (b2 - b1) / (k1 - k2) + b1);
