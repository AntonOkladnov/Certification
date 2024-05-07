## ИНСТРУКЦИЯ

1. Пользователь вводит строки через пробел.
Разделяем введенную строку на массив строк с помощью input.Split(' ').

```sh
 Console.Write("Введите строки через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
```        

2. Функция GetShortStrings принимает массив строк и возвращает новый массив строк длиной не более 3 символов. Cначала подсчитывается количество строк длиной не более 3 символов.

```sh
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
```

3. Создается новый массив shortStrings нужного размера. Затем цикл проходит по исходному массиву и копирует строки длиной не более 3 символов в новый массив.

```sh
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
```
4. Затем выводим строки из нового массива на консоль. 

```sh
Console.WriteLine("Строки длиной не более 3 символов:");
        foreach (string str in shortStrings)
        {
            Console.WriteLine(str);
        }
```        

*Пример работы программы:*

```sh
Введите строки через пробел: Hello 2 world :-
Строки длиной не более 3 символов:
2
:-
```