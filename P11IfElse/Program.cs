

Console.WriteLine("What's your age?");

int age = Convert.ToInt32(Console.ReadLine());

if (age >= 20)
{
  Console.WriteLine("You are a grownup");
}
else if (age <= 12)
{
  Console.WriteLine("You are a child");
}
else 
{
  Console.WriteLine("You are teenager");
}

Console.WriteLine("Give me an integer (A whole number)");

int newNum = Convert.ToInt32(Console.ReadLine());

if (age > newNum)
{
  Console.WriteLine("The maximum is: " + age);
}
else
{
  Console.WriteLine("The maximum is: " + newNum);
}

if (age % 2 == 0)
{
  Console.WriteLine("Your number is an even number.");
}
else
{
  Console.WriteLine("Your number is an odd number.");
}
