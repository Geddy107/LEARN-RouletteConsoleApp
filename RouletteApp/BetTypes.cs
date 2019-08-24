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


        public void Numbers()
        {
            Tuple<string, string, bool, bool, bool, bool, bool>[] Numbers = // {number, color, columnbet, rowbet, firsttwelvebet, secondtwelvebet, thirdtwelvebet,  
            {
                Tuple.Create("1", "black", true, false, true, false, true)
                Tuple.Create("2",)
                Tuple.Create("3",)
                Tuple.Create("4",)
                Tuple.Create("5",)
                Tuple.Create("3",)
                Tuple.Create("6",)
                Tuple.Create("7",)
                Tuple.Create("8",)
                Tuple.Create("9",)
                Tuple.Create("10",)
                Tuple.Create("11",)
                Tuple.Create("12",)
                Tuple.Create("13",)
                Tuple.Create("14",)
                Tuple.Create("15",)
                Tuple.Create("16",)
                Tuple.Create("17",)
                Tuple.Create("18",)
                Tuple.Create("19",)
                Tuple.Create("20",)
                Tuple.Create("21",)
                Tuple.Create("22",)
                Tuple.Create("23",)
                Tuple.Create("24",)
                Tuple.Create("25",)
                Tuple.Create("26",)
                Tuple.Create("27",)
                Tuple.Create("28",)
                Tuple.Create("29",)
                Tuple.Create("30",)
                Tuple.Create("31",)
                Tuple.Create("32",)
                Tuple.Create("33",)
                Tuple.Create("34",)
                Tuple.Create("35",)
                Tuple.Create("36",)
                Tuple.Create("0",)
                Tuple.Create("00",)


            };

        }

        public void SingleNumberBet()
        {
            int itemRandom; 



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
