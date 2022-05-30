Console.WriteLine("Hey, what's your age");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput); 


bool isChild = age is <= 12 and >= 0;
Console.WriteLine("you are a child: "+isChild);

bool isTeenager = age is >= 13 and <= 19;
Console.WriteLine("you are a teenager: "+isTeenager);

bool isAdult = age is >= 20 and <= 150;
Console.WriteLine("you are a adult: "+isAdult);