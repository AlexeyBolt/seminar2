// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
Console.Clear();

int number = new Random().Next(10,100);
Console.WriteLine(number);

int firstDigit = number % 10;
int lastDigit = number / 10;

if (firstDigit > lastDigit)
    Console.WriteLine(firstDigit);
else 
    Console.WriteLine(lastDigit);