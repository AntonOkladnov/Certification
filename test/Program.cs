        Console.Write("Введите строки через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        string[] shortStrings = GetShortStrings(inputArray);

        Console.WriteLine("Строки длиной не более 3 символов:");
        foreach (string str in shortStrings)
        {
            Console.WriteLine(str);
        }

    string[] GetShortStrings(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] shortStrings = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                shortStrings[index] = str;
                index++;
            }
        }

        return shortStrings;
    }
