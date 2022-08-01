// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру соответствующую дню недели : ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 6;
int num2 = 8;

if (num<num1)
{
    Console.WriteLine($"{num} -> будний день ");
}

if(num==num1 || num==7)
{
    Console.WriteLine($"{num} -> выходной");
}

if(num>=num2)
{
    Console.WriteLine($"{num} -> Ошибочно введенное значение, не из диапазона 1-7");
}


