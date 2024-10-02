int KeshaAge = 22;
System.Console.WriteLine("Enter your name  ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age:  ");
string AgeAsString = Console.ReadLine();
System.Console.WriteLine("Converting...  ");
int age = Convert.ToInt32(AgeAsString);
System.Console.WriteLine($"Successfully converted {age}");
int ageDifference = age - KeshaAge;
System.Console.WriteLine($"Sizning yoshingiz va Kescha yoshi o'rtasidagi farq: {ageDifference} yil ");











// System.Console.WriteLine("Enter a number with decimal places: ");
// string numberAsString = Console.ReadLine();
// System.Console.WriteLine("Converting to double...");
// double number = Convert.ToDouble(numberAsString);
// System.Console.WriteLine($"Successfully converted {number}");

// System.Console.WriteLine("Enter your height in meters: ");
// string heightAsString = Console.ReadLine();
// System.Console.WriteLine("Converting to double...");
// double height = Convert.ToDouble(heightAsString);
// System.Console.WriteLine($"Successfully converted {height} meters");


