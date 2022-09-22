Console.WriteLine("Для информции являеется ли день выходным введите номер дня недели.");
int input = Convert.ToInt32(Console.ReadLine());
    if (input>5 && input<8)
        Console.WriteLine("да, это выходной");
    else if (input<6)
        Console.WriteLine("нет, это будний день");
    else if (input>7)
        Console.WriteLine("Нет такого дня недели");