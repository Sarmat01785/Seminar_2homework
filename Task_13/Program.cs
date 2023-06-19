/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

int DigitNumber(int num)
{
    int index = 1;
    int ind = 0;
    while (num >= 1)
    {
        num = num / 10;
        index = index * 10;

    }
    ind = index / 1000;
    return ind;
}

if (number < 100 )
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digitnum = DigitNumber(number);
    number = number / digitnum;
    Console.WriteLine(number % 10);
}

/*
int Promt(string messag)
{
    Console.Write(messag);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool validateNumber(int number)
{
     if (number < 100)
     {
        Console.WriteLine("Третьей цифры нет");
        return false;
     }
    return true;
}

int number = Promt("Введите число: ");
if (validateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
*/