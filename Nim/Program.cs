using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
namespace ProjectNim;

class nimGame
{
    static void Main()
  {
      Console.WriteLine("Welcome To Nim!");
    bool Winning = false;
    int CurrentMatch = 24;
    int maxMatch = 24;
    Random random= new Random();
    int AIrandom;
    
    Console.WriteLine("|||||||||||||||||||||||| (24)");
    Retry:
    Console.WriteLine("You can only do 1,2 or 3 match drawn");
    Console.WriteLine("How many matches do you want to draw?");
    
                 while (Winning == false)
                 {
                     double drawAmmount = Convert.ToDouble(Console.ReadLine());
                   
                   
                     if (drawAmmount == 1)
                     {
                       
                         Console.WriteLine("You drew 1 match.");
                       
                         CurrentMatch--;
                       
                         Console.WriteLine("There are "+ CurrentMatch + " Matches left.");
                      
                       
                     }
                     else if (drawAmmount == 2)
                     {
                       
                         Console.WriteLine("You drew 2 matches.");
                         CurrentMatch = CurrentMatch -2;
                       
                         Console.WriteLine("There are "+ CurrentMatch + " Matches left.");
                       
                     }
                     else if (drawAmmount == 3)
                     {
                         CurrentMatch = CurrentMatch -3;
                         Console.WriteLine("You drew 3 matches."); 
                         Console.WriteLine("There are "+ CurrentMatch + " Matches left.");
                     }
                     else
                     {
                         Console.WriteLine("Man you stopid... between number 1-3?!");
               
                         goto Retry;
                     }

                     if (CurrentMatch <= 0)
                     {
                         Winning = true;
                         Console.WriteLine("AI won!!");
                     }
                     AIrandom = random.Next(1,4);
                     //Console.WriteLine(random);
                     if (AIrandom == 1)
                     {
                         CurrentMatch = CurrentMatch - 1;
                         Console.WriteLine(" The AI drew 1 match");
                         Console.WriteLine("There are now " + CurrentMatch + " matches left.");
                     }
                     else if (AIrandom == 2)
                     {
                         CurrentMatch = CurrentMatch - 2;
                         Console.WriteLine(" The AI drew 2 match");
                         Console.WriteLine("There are now " + CurrentMatch + " matches left.");
                     }
                     else
                     {
                         CurrentMatch = CurrentMatch - 3;
                         Console.WriteLine("The Ai drew 3 matches.");
                         Console.WriteLine("There are now " + CurrentMatch + " matches left");
                     } 
                     if (CurrentMatch <= 0)
                     {
                         Winning = true;
                         Console.WriteLine("Player Won!!");
                     }
                           
                 } 
            
        
  }
  
  
}







