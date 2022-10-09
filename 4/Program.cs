// Показать кубы чисел, заканчивающихся на четную цифру

int[] numbers = new int[]{2, 44, 32, 78, 173, 12};

for (int i = 0; i < numbers.Length; i++)
{
     int number = numbers[i];
     int cube = (int)Math.Pow(number, 3);
     if (cube % 2 == 0)
          System.Console.WriteLine("Куб числа " + number + " равен " + cube + " и заканчивается на чётную цифру");
}
