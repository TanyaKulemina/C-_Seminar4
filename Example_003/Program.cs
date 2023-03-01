/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message); 
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0) 
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

int Multip(int number)
{
    int multip = 1;
    for (int i = 1; i <= number; i++)
    {
        multip = multip * i;  
    }
    return multip;
}

int a = GetNumber("Введите число");
int b = Multip(a);
Console.WriteLine(b);