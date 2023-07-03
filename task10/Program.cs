// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
Console.Write("Введите трехзначное положительное число: ");
int n = int.Parse(Console.ReadLine());
while (n < 100 || n > 999) {
    Console.WriteLine ("Это число не трехзначное положительное");
    Console.Write("Введите трехзначное положительное число: ");
    n = int.Parse(Console.ReadLine());
}
int secondNumber = n / 10 % 10;
Console.WriteLine ($"Вторая цифра числа {n} --> {secondNumber}");