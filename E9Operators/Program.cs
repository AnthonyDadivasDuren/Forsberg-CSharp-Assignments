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

int secPerMin = 60;
int minPerHour = 60;
int hourPerDay = 24;

int originalTotalSeconds = 0;
int totalDays = 0;
int totalHours = 0;
int totalMinutes = 0; 
int totalSeconds = 0;
int remainingSeconds = 0;

double totalDaysFraction = 0.0;



    Input();

    Convert();

    Output();




void Input()
{
    bool isRunning = true;
    while (isRunning)
    {
        Console.Clear();
        Console.WriteLine("Give me a number of seconds");

        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out totalSeconds))
        {
            if (totalSeconds < 0)
            {
                Console.Clear();
                Console.WriteLine("Please enter a positive number.\nPress Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                isRunning = false;
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
    originalTotalSeconds = totalSeconds;

    totalDays = totalSeconds / (secPerMin * minPerHour * hourPerDay);
    remainingSeconds = totalSeconds % (secPerMin * minPerHour * hourPerDay);

    totalHours = remainingSeconds / (secPerMin * minPerHour);
    remainingSeconds %=  (secPerMin * minPerHour);

    totalMinutes = remainingSeconds / secPerMin;
    remainingSeconds %= secPerMin;

    totalSeconds = remainingSeconds;

    totalDaysFraction = (double)originalTotalSeconds / (secPerMin * minPerHour * hourPerDay);
 
}

void Output()
{
    Console.WriteLine($"Seconds: {totalSeconds}");
    Console.WriteLine($"Minutes: {totalMinutes}");
    Console.WriteLine($"Hours: {totalHours}");
    Console.WriteLine($"Days: {totalDays}");
    Console.WriteLine($"{totalDays}.{totalHours}:{totalMinutes}:{totalSeconds}");
    Console.WriteLine($"In total, that's {totalDaysFraction} Days");
}

