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















