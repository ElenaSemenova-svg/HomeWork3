//Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


float GetNumber(string message)
{
    float result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(float.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

double GetDistanse(float x1, float y1, float z1, float x2, float y2, float z2)
{
double result=Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)*1.0);
return result;
}

float x1 = GetNumber("Введите  координату Х первой точки:");
float y1 = GetNumber("Введите  координату Y первой точки:");
float z1 = GetNumber("Введите  координату Z первой точки:");

float x2 = GetNumber("Введите  координату Х второй точки:");
float y2 = GetNumber("Введите  координату Y второй точки:");
float z2 = GetNumber("Введите  координату Z второй точки:");

Console.WriteLine($"Расстояние между точками в 3D пр-ве {GetDistanse(x1,y1,z1,x2,y2,z2)}");
