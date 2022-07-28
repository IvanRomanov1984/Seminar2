// Задача 10: 
//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 1000);
int SecondNumber (int number)
{

int firstNumber = number / 10;
int secondNumber = firstNumber % 10;
int thirdNumber = secondNumber +0; 

return thirdNumber;

}

int thirdNumber = SecondNumber(num);
Console.WriteLine($"{num} -> {thirdNumber}");

