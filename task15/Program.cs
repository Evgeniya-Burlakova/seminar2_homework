// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n<1 || n>7) {
    Console.WriteLine ("Нет такого дня недели");
}
if (n>=1 && n<6) {
    Console.WriteLine ("Это будний:(");
}
if (n==6 || n==7) {
    Console.WriteLine ("Это выходной:)");
}

