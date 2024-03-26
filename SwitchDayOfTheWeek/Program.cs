int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0 on tegelikult sama mis if(weekDay ==0)
        Console.WriteLine("It`s Sunday");
        break;
    case 1:
        Console.WriteLine("Itś Monday");
        break;
    case 2:
        Console.WriteLine("Itś Tuesday");
        break;
    case 3:
        Console.WriteLine("Itś Wednesday");
        break;
    case 4:
        Console.WriteLine("Itś Thursday");
        break;
    case 5:
        Console.WriteLine("Itś Friday");
        break;
    case 6:
        Console.WriteLine("Itś Saturday");
        break;
    default:
        Console.WriteLine("Oops. Youŕe calender must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");