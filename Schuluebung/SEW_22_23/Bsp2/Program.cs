using PrimeFactors;

PrimeNumber primeNumber1 = new PrimeNumber();

primeNumber1.PrimeFactorFound += printPrimFaktor;

primeNumber1.GeneratePrimeFactorsAsync(275);

PrimeNumber primeNumber2 = new PrimeNumber();

primeNumber2.PrimeFactorFound += (number) => Console.WriteLine("Es wurde eine Primfaktor gefunden: " +number);

primeNumber2.GeneratePrimeFactorsAsync(275);

void printPrimFaktor(int number){
    Console.WriteLine("Es wurde eine Primfaktor gefunden: " + number);
}