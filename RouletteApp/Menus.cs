using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteApp
{
    public class Menus
    {
        public int UserInput()
        {
           int userselect =  Console.Read();
            return userselect;
        }


        public void InitialMenu()
        {

             
            Console.WriteLine("Wecome to the Roulette Table! Please select a number for how would you like to place your bets?");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("1...Single Number Bet");
            Console.WriteLine("2...Evens/Odds");
            Console.WriteLine("3....Red/Black");
            Console.WriteLine("4....Low (1-18)/High (19-38)");
            Console.WriteLine("5....1st Twelve, 2nd Twelve, 3rd Twelve");
            Console.WriteLine("6....Rows: 1st, 2nd, 3rd");
            Console.WriteLine("7....Columns: 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th, 9th, 10th, 11th, 12th");
            Console.WriteLine("8....Double Rows: 1/2, 2/3, 3/4, 4/5, 5/6, 6/7, 7/8, 8/9, 9/10, 10/11, 11/12");
            Console.WriteLine("9...Split Between Two Individual Numbers");
            Console.WriteLine("10...Corner Bet, Any Four Contiguous Numbers");

            


            switch (UserInput())
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                case 9:

                    break;

                case 10:

                    break;

                default:

                    break;
            }
        }


    }






}   
