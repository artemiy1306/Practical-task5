// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.  пример [345, 897, 568, 234] -> 2
Console.Clear();
int[] FillArray(int length, int minNum, int maxNum)
{
  int[] array = new int[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    array[i] = rand.Next(minNum, maxNum + 1);
  return array;
}

void EvenArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  if (count > 0)
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
  else Console.WriteLine("В массиве нет четных чисел");
}

Console.Clear();
int[] array = FillArray(12, 100, 999);
Console.WriteLine(string.Join(", ", array));
EvenArray(array);
