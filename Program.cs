// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArrayRandomNumbers(nums);
Console.WriteLine("Массив: ");
PrintArray(nums);
int count = 0;

for (int z = 0; z < nums.Length; z++)
if (nums[z] % 2 == 0)
count++;

Console.WriteLine($"всего {nums.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}
