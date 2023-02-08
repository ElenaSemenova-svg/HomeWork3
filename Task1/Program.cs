// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

int CheckDidit(int number)
{
if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else 
    Console.WriteLine("Число не является палиндромом");
return number;
}
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result >10000 && result < 99999)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или не пятизначное число. Повторите ввод");
        }
    }

    return result;
}

int number = GetNumber("Введите пятизначное число: ");
CheckDidit(number);


// Вариант 2 массив
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// if ( number.Length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"Число {number} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} не является палиндромом");
//     }
// }
// else
//     {
//         Console.WriteLine("Вы ввели не пятизначное число");
//     }


