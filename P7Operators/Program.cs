

//Example 1:
int add = 7;
int add2 = 5;
int Mult = 3;
int Sub = 6;
double Div = 1.2;
int mod = 17;
Console.WriteLine((((add+add2)*Mult-Sub)/Div) % 17);

//Example 2:
double number = 5;
number += 7; // number = 12
number *= 3; // number = 36
number -= 6; // number = 30
number /= 1.2; // number = 25
double remainder = number % 17; // Reaminder = 8, 25 / 17 works one time, then it's not a integer and therefore the remainder is 25 - 17

Console.WriteLine(remainder);

//Example 3:
remainder = ((((5 + 7) * 3) - 6) / 1.2 ) % 17;
Console.WriteLine(remainder);