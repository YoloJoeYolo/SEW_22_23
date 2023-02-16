using IShape_2_1;

List <IShape> shapes = new List <IShape> ();
shapes.Add(new Circle(3.5));
shapes.Add(new Rectangle(3, 4));
shapes.Add(new Circle(10));
shapes.Add(new Rectangle(5, 5));

shapes.ForEach(item => {
    Console.WriteLine("Area: " + item.CalculateArea());
    Console.WriteLine("Cirumference: " + item.CalculateCircumference());
    });