// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumberByUser(string n)
{
    Console.Write(n);
    return Convert.ToInt32(Console.ReadLine());
}


double k1 = GetNumberByUser("Введите k1: ");
double b1 = GetNumberByUser("Введите b1: ");
double k2 = GetNumberByUser("Введите k2: ");
double b2 = GetNumberByUser("Введите b2: ");


void GetCoord(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        System.Console.WriteLine($"Координаты перечесения двух прямых: (x: {x} , y: {y})");
    }
}

GetCoord(k1, b1, k2, b2);

