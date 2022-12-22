using _11_IComparable;

Student stefan = new Student() { FirstName = "Stefan", LastName = "Schwödiauer", Birthday = new DateTime(2005, 8, 29)};
Student gabriel = new Student() { FirstName = "Gabriel", LastName = "Steinwander", Birthday = new DateTime(2005, 2, 24) };
Student florian = new Student() { FirstName = "Florian", LastName = "Winkler", Birthday = new DateTime(2005, 3, 28) };

List<Student> students = new List<Student>();
students.Add(florian);
students.Add(gabriel);
students.Add(stefan);

students.Sort();

students.ForEach(s => Console.WriteLine(s));

//foreach(Student s in students)
//{
//    Console.WriteLine(s);
//}
