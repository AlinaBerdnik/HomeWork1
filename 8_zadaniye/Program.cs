{
            Console.WriteLine("Программа выдачи ряда четных чисел до значения.");
            Console.Write("Введите число: ");

            int input = int.Parse(Console.ReadLine());

            for (int counter = 0; counter <= input; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.Write(counter + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Выполнение программы завершено.");
        }
