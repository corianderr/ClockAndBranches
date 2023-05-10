Console.WriteLine("Hello! Welcome to Angle Counting app!\nYou give us the hours and minutes, " +
              "and we in turn give you the smaller angle between the hands of analogue clock! Pretty cool, isn't it?");
var hour = GetIntFromInputInRange("hour",1, 12);
var minutes = GetIntFromInputInRange("minutes", 1, 60);




int GetIntFromInputInRange(string name, int min, int max)
{
    int num;
    Console.Write(
        $"Enter {name}: ");
    while (!(Int32.TryParse(Console.ReadLine(), out num) && num <= max && num >= min))
    {
        Console.Write($"Be careful, input must be must be an integer number between {min} and {max} inclusive. Try again: ");
    }

    return num;
}