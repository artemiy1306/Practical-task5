// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// пример [3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0


int[] FillArray(int length, int minNum, int maxNum)
{
  int[] array = new int[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    array[i] = rand.Next(minNum, maxNum + 1);
   return array;
}

void SummArray(int[] num)
{
        int sum = 0;
        for(int i = 1; i < num.Length; i+=2 )
        {
           sum  = sum + num[i];
        }
       Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива равна {sum}");
}

Console.Clear();
int[] num = FillArray(6, -10, 10);
Console.WriteLine(string.Join(", ", num));
SummArray(num);
