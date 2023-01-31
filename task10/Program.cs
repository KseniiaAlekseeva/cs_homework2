// Program takes three-digit number as input 
// and gives the second digit of this number as output.

bool corr = false;
int num = 0, secNum = 0;

while (corr == false)
{
    Console.WriteLine("Enter a three-digit number: ");
    num = int.Parse(Console.ReadLine());
    if (num / 100 < 10)
    {
        secNum = Math.Abs((num % 100) / 10);
        Console.WriteLine($"The second digit of number {num} is {secNum}: ");
        corr = true;
    }
}