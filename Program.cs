    int x, a, x2 = 0;
    Console.Write("Введите пятизначное число: ");
    string s = Console.ReadLine();     
    if (int.TryParse(s, out x))
    {
      if (s[0]>99999 && s[0]<10000)Console.WriteLine("не пятизначное число");
        else
            {
             a = x;
             while (a > 0)
                {
                    x2 *= 10;
                    x2 += a % 10;
                    a /= 10;
            }
            if (x == x2) Console.WriteLine("палиндром");
            else Console.WriteLine("не палиндром");
        }
    }
    else
     {
        Console.WriteLine("Введено не число");
    }