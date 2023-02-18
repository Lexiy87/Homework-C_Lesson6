// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber (string message)
{
    double number = 0;
    System.Console.WriteLine(message);

    while (true)
    {
        if(double.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else System.Console.WriteLine("Неверный ввод, повторите");
    }
    return number;
}

void FindIntersectionPoint (double k1, double k2, double b1,double b2)
{

    if (k1!=k2)
    {
        double result = (b2-b1)/(k1-k2);
        System.Console.WriteLine("Точка пересечения " + result);
    }
    else System.Console.WriteLine("Нет точек пересечения ");
    
}

double b1 = GetNumber("Введите координаты b1");
double b2 = GetNumber("Введите координаты b2");
double k1 = GetNumber("Введите координаты k1");
double k2 = GetNumber("Введите координаты k2");
FindIntersectionPoint (k1,k2,b1,b2);
// System.Console.WriteLine("Точка пересечения" + result);