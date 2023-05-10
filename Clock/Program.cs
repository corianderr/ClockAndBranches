const int oneMinuteDegreeForMinutesArrow = 6;
const double oneMinuteDegreeForHoursArrow = 0.5;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello! Welcome to Angle Counting app!\nYou give us the hours and minutes, " +
                  "and we in turn give you the smaller angle between the hands of analogue clock! Pretty cool, isn't it?\n");
Console.ResetColor();

var hours = GetIntFromInputInRange("hour", 1, 12);
var minutes = GetIntFromInputInRange("minutes", 1, 59);

var hourAngle = (hours * 60 + minutes) * oneMinuteDegreeForHoursArrow;
var minutesAngle = minutes * oneMinuteDegreeForMinutesArrow;

var minAngle = Math.Abs(hourAngle - minutesAngle);
minAngle = minAngle <= 180 ? minAngle : 360 - minAngle;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nThe lesser angle between the arrows indicating {hours} hours and {minutes} minutes is {minAngle} degrees!");
Console.ResetColor();


int GetIntFromInputInRange(string name, int min, int max)
{
    int num;
    Console.Write(
        $"Enter {name}: ");
    while (!(Int32.TryParse(Console.ReadLine(), out num) && num <= max && num >= min))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(
            $"Be careful, input must be must be an integer number between {min} and {max} inclusive.\nTry again: ");
        Console.ResetColor();
    }

    return num;
}