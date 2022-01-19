    Console.WriteLine("Введите число A");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберите какую операцию Вы хотите выполнить с числами\n1 - Сложить\n2 - Вычесть\n3 - Умножить\n4 - Поделить");
    int choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            {
                addnumbers();
            }
            break;
        case 2:
            {
                subtractnumbers();
            }
            break;
        case 3:
            {
                multilpynumbers();
            }
            break;
        case 4:
            {
                dividenumbers();
            }
            break;

        default:
            break;
    }