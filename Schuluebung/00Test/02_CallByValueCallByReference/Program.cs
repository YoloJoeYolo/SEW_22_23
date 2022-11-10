using _02_CallByValueCallByReference;

void SwapD(double a, double b)
{
    double temp = a;
    a = b; 
    b = temp;
}

void SwapDRef(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}

void SwapS(Student a, Student b)
{
    Student temp = a;
    a = b;
    b=temp;
    a.FirstName = "Dr. " + a.FirstName;     // Änderungen am Objekt selbst, sind natürlich nach außen hin sichtbar 
}

void SwapSRef(ref Student a, ref Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}

void generateNumber(out int number)
{
    number = 100;
}

void generateNumbers(out int a, out int b)
{
    a = 100;
    b = 200;
}

void generateNumbersArray(out int[] numbers)
{
    numbers = new int[3];
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i * 2;
    }
}
double a = 5.0;
double b = 3.5;

SwapD(a, b);    // call by value
Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

SwapDRef(ref a, ref b);    // call by reference
Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

Student elias = new Student() { FirstName = "Elias", LastName = "Seeböck"};
Student tobias = new Student() { FirstName = "Tobias", LastName = "Zarzer" };
SwapS(elias, tobias);   // call by value
Console.WriteLine("Elias: " + elias);
Console.WriteLine("Tobias: " + tobias);
SwapSRef(ref elias, ref tobias);   // call by reference
Console.WriteLine("Elias: " + elias);
Console.WriteLine("Tobias: " + tobias);

int i;
//Console.WriteLine("i: " + i); Variable kann noch nicht verwendet werden
generateNumber(out i);  // nach Aufrug ist die Variable sicher inializiert
Console.WriteLine("i: " + i);

int[] myNumbers;
generateNumbersArray(out myNumbers);    // nach Aufruf ist das Array sicher initialisiert.
for (int j = 0; j < myNumbers.Length; j++)
{
    Console.WriteLine(i);
}