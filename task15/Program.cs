// Program takes the number of the day of the week as input 
// and checks if it's a holiday.  

int num = 0;
while ((num < 1) || (num > 7))
{
    Console.WriteLine("Enter the number of the day of the week: ");
    num = int.Parse(Console.ReadLine());

    if (num > 5) Console.WriteLine($"The day with number {num} is a holiday.");
    else Console.WriteLine($"The day with number {num} is not a holiday.");
}