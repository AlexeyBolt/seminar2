// Напишите программу, которая будет принимать на вход 2 числа и выводить, 
//является ли второе число кратное числу 1, если число 2 не кратно, 
//то программа выводит остаток от деления
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!); // ! ставится как предупреждение, что есть Null и выскакивают Желтые напоминалки
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a < b)
{
    Console.Write("Первое исло должно быть больше второго");

}
else if (a % b == 0)
    Console.Write($"{a} крастное {b}");
else    
    Console.Write($"остаток от деления {a % b}");