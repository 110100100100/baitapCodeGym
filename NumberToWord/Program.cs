 Console.WriteLine("Nhập số cần đọc:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("out of ability");
                    break;
            }
        }
        else if (number < 20)
        {
            int ones = number % 10;
            switch (ones)
            {
                case 0:
                    Console.WriteLine("ten");
                    break;
                case 1:
                    Console.WriteLine("eleven");
                    break;
                case 2:
                    Console.WriteLine("twelve");
                    break;
                case 3:
                    Console.WriteLine("thirteen");
                    break;
                case 4:
                    Console.WriteLine("fourteen");
                    break;
                case 5:
                    Console.WriteLine("fifteen");
                    break;
                case 6:
                    Console.WriteLine("sixteen");
                    break;
                case 7:
                    Console.WriteLine("seventeen");
                    break;
                case 8:
                    Console.WriteLine("eighteen");
                    break;
                case 9:
                    Console.WriteLine("nineteen");
                    break;
            }
        }
        else if (number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;

            switch (tens)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("forty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
            }

            if (ones > 0)
            {
                Console.Write(" ");
                switch (ones)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
        }
        else if (number < 1000)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            switch (hundreds)
            {
                case 1:
                    Console.Write("one hundred");
                    break;
                case 2:
                    Console.Write("two hundred");
                    break;
                case 3:
                    Console.Write("three hundred");
                    break;
                case 4:
                    Console.Write("four hundred");
                    break;
                case 5:
                    Console.Write("five hundred");
                    break;
                case 6:
                    Console.Write("six hundred");
                    break;
                case 7:
                    Console.Write("seven hundred");
                    break;
                case 8:
                    Console.Write("eight hundred");
                    break;
                case 9:
                    Console.Write("nine hundred");
                    break;
            }

            if (tens > 1)
            {
                Console.Write(" and ");
                switch (tens)
                {
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirty");
                        break;
                    case 4:
                        Console.Write("forty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("ninety");
                        break;
                }
            }

            if (tens != 1 && ones > 0)
            {
                Console.Write(" ");
                switch (ones)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
        }