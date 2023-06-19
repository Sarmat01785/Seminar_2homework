/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

void ThreeDigitArray(int[] array)
{
    for (int i = 0; i < array.Length; i++);
        
}
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num >= 1000)
{
    Console.WriteLine("Введено не трехзначное число");
    return;
}
int temp = num;

int count = 0;
while (temp != 0)
{
    temp = temp / 10; // temp /= 10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

Console.Write($"{array[1]}");

/*
int ThreeDigitNumber(string messag)
{
    Console.Write(messag);
    string res = Console.ReadLine();
    int result = Convert.ToInt32(res);
    return result;
}

int number = ThreeDigitNumber("введите трехзначное число: ");

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Введено не трехзначное число");
    return;
}
int rem = number / 10;

int Result = rem % 10;

Console.WriteLine($"{Result}");
*/
