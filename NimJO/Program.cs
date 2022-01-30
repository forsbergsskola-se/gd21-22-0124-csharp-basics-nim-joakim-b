using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.CompilerServices;

namespace Nim;

class NimGame
{

 
       static void Main()
     {
       Console.WriteLine("Welcome to NIM!!");
       bool Winning = false;
       int CurrentMatch = 24;
       int maxMatch = 24;
       int AIrandom;
       Random NewRandom = new Random();
       Console.WriteLine("|||||||||||||||||||||||| (24)");
       RETRY:
       Console.WriteLine("You can only draw 1,2 or 3 matches.");
       Console.WriteLine("How many matches would you like to draw?");

         while (Winning == false)
         {
             double drawAmount = Convert.ToDouble(Console.ReadLine());

              if (drawAmount == 1)
              {
               Console.WriteLine("You draw 1 match");

               CurrentMatch--;

               Console.WriteLine(" There is" + CurrentMatch + " Matches left.");

              }
              else if (drawAmount == 2)
              {
               Console.WriteLine(" You Draw 2 Matches.");
               CurrentMatch = CurrentMatch - 2;
               Console.WriteLine("There is " + CurrentMatch + " Matches left.");
              }
              else if (drawAmount == 3)
              {
               CurrentMatch = CurrentMatch - 3;
               Console.WriteLine("You draw 3 matches.");
               Console.WriteLine("There is " + CurrentMatch + " Matches left.");
              }
              else
              {
               Console.WriteLine("HEY YOU CAN ONLY DRAW 1-3 MATCHES YOU CHEAT!, lucky for you this is not the wild west.");

               goto RETRY;
              }

              if (CurrentMatch <= 0)
              {

              Winning = true;
              Console.WriteLine("Me the great AI WON!");
              }

              AIrandom = NewRandom.Next(1, 4);
              //console.WriteLine(ranodom);
              if (AIrandom == 1)
             {
              CurrentMatch = CurrentMatch - 1;
              Console.WriteLine(" AI draws 1 match");
              Console.WriteLine(" There is " + CurrentMatch + " Matches left.");

             }
             else if (AIrandom == 2)

             {
              CurrentMatch = CurrentMatch - 2;
              Console.WriteLine(" AI draws 2 matches");
              Console.WriteLine(" There is " + CurrentMatch + " Matches left");
             }
             else
             {
              CurrentMatch = CurrentMatch - 3;
              Console.WriteLine(" AI draws 3 matches");
              Console.WriteLine("There is " + CurrentMatch + "  Matches left");
             }
             if (CurrentMatch <= 0)
             {
              Winning = true;
              Console.WriteLine("Oh look, the human won! i need repairs...");
             }
   
   
   
         }       
        
}


       
       }          
 

