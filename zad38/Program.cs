// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива. 
// [3 7 22 2 78] -> 76
double[] FillArray(int length, int minNum, int maxNum)
{
  double[] array = new double[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    array[i] = Convert.ToDouble(rand.Next(minNum, maxNum + 1));
  return array;
}

void Raz(double[] num)
{
  double min = num[0];
  double max = num[0];
  for (int i = 1; i < num.Length; i++)
  {
    if (max < num[i]) max = num[i];
    if (min > num[i]) min = num[i];
  }
  Console.Write($"Разница между максимальным и минимальным элементов массива: {max - min}");
}

Console.Clear();
double[] num = FillArray(10, 10, 99);
Console.WriteLine(string.Join(", ", num));
Raz(num);