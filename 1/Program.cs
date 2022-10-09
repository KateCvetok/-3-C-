// Найти кубы чисел от 1 до N
Console.WriteLine ("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
while (a<=N)
{
    int cub = a*a*a;
    Console.WriteLine($"a={a}, куб числа a = {cub}");
    a++;
}