// Задача 34

// System.Console.WriteLine( "Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// RandomArray(numbers);
// for (int a = 0; a < numbers.Length; a++)
// if (numbers[a] % 2 == 0)
// count++;

// System.Console.WriteLine($"{count} Чисел являются чётными");

// void RandomArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000); 
//         System.Console.Write($"  [ {numbers[i]} ] " );
//     }
// }

// Задача 36

// System.Console.WriteLine( "Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int sum = 0;
// RandomArray(numbers);
// for (int a = 0; a < numbers.Length; a +=2)
// sum += numbers[a];

// System.Console.WriteLine($" Сумма чисел на нечетных позициях = {sum} ");

// void RandomArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(-100, 1000); // Ограничение поставлено для того чтобы не выводить слишком большие числа. 
//         System.Console.Write($" Число [ {numbers[i]} ] " );
//     }
// }

// Задача 38

// System.Console.WriteLine( "Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// RandomArray(numbers);
// double max = 0;
// double min = 0;
// for (int a = 0; a < numbers.Length; a ++)
// {
//     if (numbers[a] > max)
//     {
//         max = numbers[a]; 
//     }
//     if (numbers[a] < min)
//     {
//         min = numbers[a];
//     }
// }
// System.Console.WriteLine($"Максимальное число = {max}, Минимальное = {min}. Разница между ними равна {max - min}");

// void RandomArray(double[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(-100, 1000); // Ограничение поставлено для того чтобы не выводить слишком большие числа. 
//         System.Console.Write($" Число [ {numbers[i]} ] " );
//     }
// }
