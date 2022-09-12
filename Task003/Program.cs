// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Method3()
{   
    // Определяем входное число
    Console.WriteLine("1 - Понедельник");
    Console.WriteLine("2 - Вторник");
    Console.WriteLine("3 - Среда");
    Console.WriteLine("4 - Четверг");
    Console.WriteLine("5 - Пятница");
    Console.WriteLine("6 - Суббота");
    Console.WriteLine("7 - Воскресенье");
    Console.WriteLine("Введите число обозначающее день недели: ");
    int dayNum = int.Parse(Console.ReadLine());
    // Определяем выходной день
    if(dayNum < 1 || dayNum > 7) Console.WriteLine("Введено неверное число");
    else if(dayNum == 6 || dayNum == 7) Console.WriteLine("Этот день выходной?: Да");
    else Console.WriteLine("Этот день выходной?: Нет");
}
Method3();
