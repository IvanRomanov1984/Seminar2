// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = 654321;
int result = 4;
int numres = 4;
int ostDel = 1;
int result1 = result;
int znah = num % 10;
int number= (num);
// int FirstNumber (int number); 

while(num != 0) 
{ 
num /= 10; 
result = result +1;
}
// Console.WriteLine($"{result}");
while (result>numres)
{
Console.WriteLine($"Третьей цыфры нет"); 
numres=numres+1;
ostDel=ostDel*10;
}   

Console.WriteLine($"{znah}");
int firstNumber = num % numres;


