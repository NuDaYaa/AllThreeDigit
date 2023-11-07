
Console.WriteLine("Все трехзначные числа, в десятичной записи в которых нет одинаковых цифр.");

    for (int i = 100; i <= 999; i++)
        {
            int number = i;
            int digit1 = number % 10;
            number /= 10;
            int digit2 = number % 10;
            number /= 10;
            int digit3 = number % 10;

            if (digit1 != digit2 && digit1 != digit3 && digit2 != digit3)
            {
                Console.WriteLine(i);
            }
        }