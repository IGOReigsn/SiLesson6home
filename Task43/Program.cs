// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// -------------------МЕТОДЫ----------------------------------------------------------------------------
double InputNumberDouble(string qwerStr)//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
    {double num;
    string? text;
    while(true)
        {
            Console.WriteLine(qwerStr);
            text=Console.ReadLine();
           if(double.TryParse(text,out num)) break;
           Console.WriteLine("Введено некорректное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
//------------------------------------------------------------------------------------------------------
// -------------------ОСНОВНАЯ ПРОГРАММА----------------------------------------------------------------------------
double b1=InputNumberDouble("Введите B1:");
double k1=InputNumberDouble("Введите К1:");
double b2=InputNumberDouble("Введите B2:");
double k2=InputNumberDouble("Введите К2:");

double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"Решение: Х={Math.Round(x,3)} Y= {Math.Round(y,3)}");