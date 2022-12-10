// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[size];
// FillArrayRandomNumbers(nums);
// Console.WriteLine("Массив: ");
// PrintArray(nums);
// int count = 0;

// for (int z = 0; z < nums.Length; z++)
// if (nums[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {nums.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//     {
//         Console.Write(nums[i] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[size];
// FillArrayRandomNumbers(nums);
// Console.WriteLine("Массив: ");
// PrintArray(nums);
// int sum = 0;

// for (int x = 0; x < nums.Length; x+=2)
//     sum = sum + nums[x];

//     Console.WriteLine($"Всего {nums.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//         {
//             nums[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//         {
//             Console.Write(nums[i] + " ");
//         }
//     Console.WriteLine();
// }



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}
