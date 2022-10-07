//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetNum(int number)
{
    int result = 0;
    int a = 0;
    int b = Convert.ToString(number).Length;

    for (int i = 0; i < b; i++)
    {
        a = number - number % 10;
        result = result + (number - a);
        number = number/10;
    }
    return result;
}
int summa = GetNum(number);
Console.WriteLine("сумма цифр: " + summa);
