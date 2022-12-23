{
            Console.WriteLine("Программа нахождения четности введеного числа.");
            Console.Write("Введите число: ");

            int input = int.Parse(Console.ReadLine());
            int findOdd = input % 2;

            if (findOdd == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
                Console.WriteLine("Число нечетное");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }