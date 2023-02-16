using PrimeNumbers_2_2;

int startNumber;
int endNumber;

PrimeNumber primeNumber = new PrimeNumber();

primeNumber.PrimeNumberFound += prim => Console.WriteLine(prim.ToString() +" is a prime number!");

Console.WriteLine("For the search of a prime number you have to define a start and a end number.");
while (true)
{
    Console.Write("Enter a start number: ");
    if (int.TryParse(Console.ReadLine(), out startNumber))
    {
        break;
    }
}
while (true)
{
    Console.Write("Enter a end number: ");
    if (int.TryParse(Console.ReadLine(), out endNumber))
    {
        break;
    }
}

Console.WriteLine("Search for prime numbers between {0} and {1} started!", startNumber, endNumber);
Task t = primeNumber.GeneratePrimeNumbersAsync(startNumber, endNumber);

t.Wait();
Console.WriteLine("Search for prime numbers between {0} and {1} finished!", startNumber, endNumber);