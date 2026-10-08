// num 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }



// num 1.2
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }




// num 2
// int sum3 = 0;
// int sum7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum3 += i;
//     }
//     if (i % 7 == 0)
//     {
//         sum7 += 1;
//     }
// }
// Console.WriteLine($"Сумма чисел, кратных 3: {sum3}");
// Console.WriteLine($"Количество чисел, кратных 7: {sum7}");


// num 3

// int number = Convert.ToInt32(Console.ReadLine());
// int pos = 0;
// int neg = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//         pos++;
//     }
//     else
//     {
//         neg++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Количество положительных чисел: {pos}");
// Console.WriteLine($"Количество отрицательных чисел: {neg}");


// num 4

// string password;
// int attempts = 0;
// do
// {
//     Console.WriteLine("Введите пароль:");
//     password = Console.ReadLine();
//     attempts++;
// } while (password != "qwerty" && attempts < 3);

// if (attempts > 3 || password != "qwerty")
// {
//     Console.WriteLine("Доступ запрещен");
// }
// else
// {
//     Console.WriteLine("Доступ разрешен");
// }



// самостоятельные задания

// 5

// Console.Write("Введите число для построения таблицы умножения: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("-------------------------------");
// Console.WriteLine($"Таблица умножения для числа {number}:");
// Console.WriteLine("-------------------------------");
// for (int i = 1; i <= 10; i ++)
// {
//     Console.WriteLine($"         {number} * {i} = {number * i}");
// } 
// Console.WriteLine("-------------------------------");


// num 6

// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
//     if (i % 10 == 0 && i > 20) 
//     {
//         break;
//     }
// }

// num 7

// int secret = new Random().Next(1, 101);
// int guess;
//     Console.Write("Угадайте число от 1 до 100: ");
// for (int i = 0; i <= 6; i++)
// {
//         if (i== 6)
//     {
//         Console.WriteLine($"Вы исчерпали все попытки. Загаданное число было: {secret}");
//         break;
//     }
//     guess = Convert.ToInt32(Console.ReadLine());

//     if (guess == secret)
//     {
//         Console.WriteLine("Вы угадали число. Попыток: " + (i + 1));
//         break;
//     }
//     else if (guess < secret)
//     {
//         Console.WriteLine("больше.");
//     }
//     else
//     {
//         Console.WriteLine("меньше.");
//     }


// }


// дополнительное задание

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToString(number).Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");
Console.WriteLine($"Количество цифр числа: {length}");