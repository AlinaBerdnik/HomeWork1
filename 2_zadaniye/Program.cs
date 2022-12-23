{
            Console.WriteLine("Программа нахождения максимального из двух.");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b) Console.WriteLine($"Число {b} большее.");
            else Console.WriteLine($"Число {a} большее.");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }