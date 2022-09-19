// напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
Console.Clear();

int number = new Random().Next(100,999);
Console.WriteLine(number);

int firstDigit = number / 100;
int secondDigit = number % 10;
Console.Write($"{firstDigit}{secondDigit}");