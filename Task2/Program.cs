// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SummNumber(int num)
{
    int counter = num;
    int advence = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advence = num - num % 10;
        result = result + (num - advence);
        num = num / 10;
    }
    return result;
}
int SumNum = SummNumber(num);
System.Console.WriteLine(SumNum);
