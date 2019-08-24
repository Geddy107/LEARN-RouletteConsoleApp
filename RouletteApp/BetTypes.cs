using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteApp
{
    class BetTypes
    {

        public int RandomNumberGen()
        {
            Random random = new Random();
            return random.Next(0, 39);
        }


         Tuple<string/*Number*/, bool?/*color*/, int/*Column Number*/, int/*Row Number*/, bool?/*1st Half*/>[] tableNumbers =
         {

                Tuple.Create("1" , true as bool?  ,  1  , 1  , true as bool?  ), //{number, is color red, columnbet, rowbet, firsttwelvebet, secondtwelvebet, thirdtwelvebet,  
                Tuple.Create("2" , true as bool?  ,  1  , 2  , true as bool?  ),
                Tuple.Create("3" , true as bool?  ,  1  , 3  , true as bool?  ),
                Tuple.Create("4" , false as bool? ,  2  , 1  , true as bool?  ),
                Tuple.Create("5" , true as bool?  ,  2  , 2  , true as bool?  ),
                Tuple.Create("6" , false as bool? ,  2  , 3  , true as bool?  ),
                Tuple.Create("7" , true as bool?  ,  3  , 1  , true as bool?  ),
                Tuple.Create("8" , false as bool? ,  3  , 2  , true as bool?  ),
                Tuple.Create("9" , true as bool?  ,  3  , 3  , true as bool?  ),
                Tuple.Create("10", false as bool? ,  4  , 1  , true as bool?  ),
                Tuple.Create("11", false as bool? ,  4  , 2  , true as bool?  ),
                Tuple.Create("12", true as bool?  ,  4  , 3  , true as bool?  ),
                Tuple.Create("13", false as bool? ,  5  , 1  , true as bool?  ),
                Tuple.Create("14", true as bool?  ,  5  , 2  , true as bool?  ),
                Tuple.Create("15", false as bool? ,  5  , 3  , true as bool?  ),
                Tuple.Create("16", true as bool?  ,  6  , 1  , true as bool?  ),
                Tuple.Create("17", false as bool? ,  6  , 2  , true as bool?  ),
                Tuple.Create("18", true as bool?  ,  6  , 3  , true as bool?  ),
                Tuple.Create("19", true as bool?  ,  7  , 1  , false as bool? ),
                Tuple.Create("20", false as bool? ,  7  , 2  , false as bool? ),
                Tuple.Create("21", true as bool?  ,  7  , 3  , false as bool? ),
                Tuple.Create("22", false as bool? ,  8  , 1  , false as bool? ),
                Tuple.Create("23", true as bool?  ,  8  , 2  , false as bool? ),
                Tuple.Create("24", false as bool? ,  8  , 3  , false as bool? ),
                Tuple.Create("25", true as bool?  ,  9  , 1  , false as bool? ),
                Tuple.Create("26", false as bool? ,  9  , 2  , false as bool? ),
                Tuple.Create("27", true as bool?  ,  9  , 3  , false as bool? ),
                Tuple.Create("28", false as bool? ,  10 , 1  , false as bool? ),
                Tuple.Create("29", false as bool? ,  10 , 2  , false as bool? ),
                Tuple.Create("30", true as bool?  ,  10 , 3  , false as bool? ),
                Tuple.Create("31", false as bool? ,  11 , 1  , false as bool? ),
                Tuple.Create("32", true as bool?  ,  11 , 2  , false as bool? ),
                Tuple.Create("33", false as bool? ,  11 , 3  , false as bool? ),
                Tuple.Create("34", true as bool?  ,  12 , 1  , false as bool? ),
                Tuple.Create("35", false as bool? ,  12 , 2  , false as bool? ),
                Tuple.Create("36", true as bool?  ,  12 , 3  , false as bool? ),
         };

        

        public void SingleNumberBet()
        {
            Menus Men = new Menus();
            Men.UserInput();


            int itemRandom = RandomNumberGen();
            var tablenum = tableNumbers[itemRandom];


            



            Menus Men = new Menus();
            Men.UserInput();


            if




        }

        public void CornerBet()
        {
            //22


        }

        public void RowBets()
        {
            // 33

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

