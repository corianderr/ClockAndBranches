const int oneMinuteDegreeForMinutesArrow = 6;
const double oneMinuteDegreeForHoursArrow = 0.5;

Console.WriteLine("Hello! Welcome to Angle Counting app!\nYou give us the hours and minutes, " +
                  "and we in turn give you the smaller angle between the hands of analogue clock! Pretty cool, isn't it?\n");

var hour = GetIntFromInputInRange("hour",1, 12);
var minutes = GetIntFromInputInRange("minutes", 1, 59);

var hourAngle = (hour * 60 + minutes) * oneMinuteDegreeForHoursArrow;
var minutesAngle = minutes * oneMinuteDegreeForMinutesArrow;

var minAngle = Math.Abs(hourAngle - minutesAngle);
minAngle = minAngle <= 180 ? minAngle : 360 - minAngle;

Console.WriteLine($"The lesser angle between hours and minutes arrows is {minAngle}");


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