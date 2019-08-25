using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteApp
{
    class Game
    {

        public int RandomNumberGen()
        {
            Random random = new Random();
            return random.Next(0, 39);
        }


         Tuple<string, bool?, int, int, bool?, int>[] tableNumbers =
         {
                        /*1: Number*/  /*2: color*/  /*3: Column Number*/  /*4: Row Number*/ /*5: 1st Half*/  /*6: 1/3rd*/
                Tuple.Create("0" ,     null as bool? ,       1 ,                1,            null as bool? ,    0  ),  
                Tuple.Create("1" ,     true as bool? ,       1 ,                1,            true as bool? ,    1  ), 
                Tuple.Create("2" ,     true as bool? ,       1 ,                2,            true as bool? ,    1  ),
                Tuple.Create("3" ,     true as bool? ,       1 ,                3,            true as bool? ,    1  ),
                Tuple.Create("4" ,     false as bool?,       2 ,                1,            true as bool? ,    1  ),
                Tuple.Create("5" ,     true as bool? ,       2 ,                2,            true as bool? ,    1  ),
                Tuple.Create("6" ,     false as bool?,       2 ,                3,            true as bool? ,    1  ),
                Tuple.Create("7" ,     true as bool? ,       3 ,                1,            true as bool? ,    1  ),
                Tuple.Create("8" ,     false as bool?,       3 ,                2,            true as bool? ,    1  ),
                Tuple.Create("9" ,     true as bool? ,       3 ,                3,            true as bool? ,    1  ),
                Tuple.Create("10",     false as bool?,       4 ,                1,            true as bool? ,    1  ),
                Tuple.Create("11",     false as bool?,       4 ,                2,            true as bool? ,    1  ),
                Tuple.Create("12",     true as bool? ,       4 ,                3,            true as bool? ,    1  ),
                Tuple.Create("13",     false as bool?,       5 ,                1,            true as bool? ,    2  ),
                Tuple.Create("14",     true as bool? ,       5 ,                2,            true as bool? ,    2  ),
                Tuple.Create("15",     false as bool?,       5 ,                3,            true as bool? ,    2  ),
                Tuple.Create("16",     true as bool? ,       6 ,                1,            true as bool? ,    2  ),
                Tuple.Create("17",     false as bool?,       6 ,                2,            true as bool? ,    2  ),
                Tuple.Create("18",     true as bool? ,       6 ,                3,            true as bool? ,    2  ),
                Tuple.Create("19",     true as bool? ,       7 ,                1,            false as bool?,    2  ),
                Tuple.Create("20",     false as bool?,       7 ,                2,            false as bool?,    2  ),
                Tuple.Create("21",     true as bool? ,       7 ,                3,            false as bool?,    2  ),
                Tuple.Create("22",     false as bool?,       8 ,                1,            false as bool?,    2  ),
                Tuple.Create("23",     true as bool? ,       8 ,                2,            false as bool?,    2  ),
                Tuple.Create("24",     false as bool?,       8 ,                3,            false as bool?,    2  ),
                Tuple.Create("25",     true as bool? ,       9 ,                1,            false as bool?,    3  ),
                Tuple.Create("26",     false as bool?,       9 ,                2,            false as bool?,    3  ),
                Tuple.Create("27",     true as bool? ,       9 ,                3,            false as bool?,    3  ),
                Tuple.Create("28",     false as bool?,       10,                1,            false as bool?,    3  ),
                Tuple.Create("29",     false as bool?,       10,                2,            false as bool?,    3  ),
                Tuple.Create("30",     true as bool? ,       10,                3,            false as bool?,    3  ),
                Tuple.Create("31",     false as bool?,       11,                1,            false as bool?,    3  ),
                Tuple.Create("32",     true as bool? ,       11,                2,            false as bool?,    3  ),
                Tuple.Create("33",     false as bool?,       11,                3,            false as bool?,    3  ),
                Tuple.Create("34",     true as bool? ,       12,                1,            false as bool?,    3  ),
                Tuple.Create("35",     false as bool?,       12,                2,            false as bool?,    3  ),
                Tuple.Create("36",     true as bool? ,       12,                3,            false as bool?,    3  ),
                Tuple.Create("00",     null as bool? ,       12,                3,            null as bool? ,    0  ),
               
         };

        

        public bool SingleNumberBet()
        {
            int spin = RandomNumberGen();
            var playerBet = 0;
            Console.WriteLine("Please Select any number on the table (00-36)");
         

            Console.WriteLine(tableNumbers[spin].Item1);
            Console.WriteLine(playerBet);

            if (playerBet.ToString() == tableNumbers[spin].Item1)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Street()
        {
            
            var randomTwo = RandomNumberGen();

                Console.WriteLine("Enter the bottom number of the street you wish to bet on.\n");

            int input = int.Parse(Console.ReadLine());

            if (input == tableNumbers[randomTwo].Item4)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public void CornerBet()
        {
            //22


        }

        public bool RowBets()
        {

            Console.WriteLine("Please select a row");
            Console.WriteLine("____________________");
            Console.WriteLine("1- (1-34)");
            Console.WriteLine("2- (2-35)");
            Console.WriteLine("3- (3-36)");
            
            int input = int.Parse(Console.ReadLine());

            var randomThree = RandomNumberGen();

            if (input == tableNumbers[randomThree].Item4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void FirstTwelve()
        {



        }

        public void SecondTwelve()
        {



        }

        public void ThirdTwelve()
        {



        }

        public void OnetoEighteen()
        {



        }

        public void NineteentoThirtysix()
        {


        }

        public void Red()
        {


        }

        public void Black()
        {


        }

        public void Even()
        {


        }

        public void Odd()
        {


        }
    }
}

