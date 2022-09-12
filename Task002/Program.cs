// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Method2()
{
    // Определяем входное число
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
        // Определяем третью цифру введенного числа
    if (number < 0) number = number * -1;
    if (number <= 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
       while (number > 999)
        {
            number = number/10;
        }
        int x = number%10;
        Console.WriteLine(x);
    }
}

Method2();
