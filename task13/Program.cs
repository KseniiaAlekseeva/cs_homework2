// Program gives the third digit of entered number
// or informs that there is no third digit

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int curnum = Math.Abs(num);
int quot = curnum;
int thirdNum = 0;

if (curnum < 100) Console.WriteLine($"Number {num} doesn't have third digit.");
else
{
    do
    {
        curnum = quot;
        quot = curnum / 10;
    }
    while (quot > 99);

    thirdNum = curnum % 10;
    Console.WriteLine($"The third digit of number {num} is {thirdNum}.");
}

