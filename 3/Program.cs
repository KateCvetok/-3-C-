// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine ("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
int mult = 1;
while (a<=N)
{
    mult = mult*a;
    a++; 
 }
 Console.WriteLine($"Произведение всех чисел равна  {mult}");