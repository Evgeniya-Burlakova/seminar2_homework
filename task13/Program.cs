// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n < 100) {
    Console.WriteLine ("Третьей цифры нет");
    return;
}
while (n>999) {
    n = n/10;
}
int thirdNumber = n % 10;
Console.WriteLine ($"Третья цифра числа --> {thirdNumber}");