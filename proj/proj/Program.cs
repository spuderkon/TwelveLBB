
﻿    Console.WriteLine("Введите число A");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберите какую операцию Вы хотите выполнить с числами\n1 - Сложить\n2 - Вычесть\n3 - Умножить\n4 - Поделить");
    int choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            {
                Console.WriteLine(addnumbers(a,b));
            }
            break;
        case 2:
            {
                Console.WriteLine(subtractnumbers(a,b));
            }
            break;
        case 3:
            {
                Console.WriteLine(multilpynumbers(a,b));
            }
            break;
        case 4:
            {
                Console.WriteLine(dividenumbers(a,b));
            }
            break;

        default:
            break;
    }

    int addnumbers(int a, int b)
    {
        return a + b;
    }
    ﻿int subtractnumbers(int a, int b)
    {
        return a - b;
    }
    ﻿int multilpynumbers(int a, int b)
    {
        return a * b;
    }
    double dividenumbers(int a, int b)
    {
        return a / b;
    }

