/*
Create a console project called E9Operators
Solve the mathematical problem using code and display the result as per the goal
Ask the user for amount of seconds
Simplify the time:
Calculate how many days, hours, minutes and seconds the time contains
Print each part of the time
Then print all components together in the format: D.H:M:S
Then print how many days this is as a fraction in total
*/

using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

// --- Variables ---
const int secPerMin = 60;
const int secPerHour = 60 * secPerMin; // 3600
const int secPerDay = 24 * secPerHour; // 86400

int originalTotalSeconds = 0;
int totalDays = 0;
int totalHours = 0;
int totalMinutes = 0; 
int inputSeconds = 0;
int remainingSeconds = 0;

double totalDaysFraction = 0.0;


// --- Program ---
    Input();

    Convert();

    Output();


// --- Methods ---
void Input()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Give me a number of seconds");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out inputSeconds))
        {
            if (inputSeconds < 0)
            {
                Console.Clear();
                Console.WriteLine("Please enter a positive number.\nPress Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                return;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"That's not a valid number, try again.\nPress Enter to Continue...");
            Console.ReadLine();
        }
    }
}

void Convert()
{
    originalTotalSeconds = inputSeconds;

    totalDays = inputSeconds / secPerDay;
    remainingSeconds = inputSeconds % secPerDay;

    totalHours = remainingSeconds / secPerHour;
    remainingSeconds %= secPerHour;

    totalMinutes = remainingSeconds / secPerMin;
    remainingSeconds %= secPerMin;

    inputSeconds = remainingSeconds;

    totalDaysFraction = (double)originalTotalSeconds / secPerDay;
}

void Output()
{
    Console.WriteLine($"Seconds: {inputSeconds}");
    Console.WriteLine($"Minutes: {totalMinutes}");
    Console.WriteLine($"Hours: {totalHours}");
    Console.WriteLine($"Days: {totalDays}");
    Console.WriteLine($"{totalDays}.{totalHours}:{totalMinutes}:{inputSeconds}");
    Console.WriteLine($"In total, that's {totalDaysFraction} Days");
}

