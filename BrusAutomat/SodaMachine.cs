using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomat
{
    class SodaMachine
    {
        private int Coins;
        private int Id;
        //SodaMachine har et array av Tilgjengelig brus? 
        //Hver individuelle brus skal ikke ha en storage? 

        public void InsertMoney(int coins)
        {
            Coins += coins;
        }
        public void ChoseSoda(Soda soda)
        {
            if (soda.Storage == 0) Console.WriteLine($"The machine is out {soda.Type}. Pick another one or leave thirsty");
            
            else if (Coins >= soda.Price)
            {
                Coins -= soda.Price;
                soda.Storage--;
                Console.WriteLine($"A {soda.Type} was violently dropped into the tray at the bottom\nThe machine has {soda.Storage} {soda.Type}s left");
            }
            else Console.WriteLine($"you need {soda.Price - Coins} more for a {soda.Type}");
        }

        public void ReturnMoney()
        {
            Console.WriteLine($"{Coins} coins was blurted out in ones");
            Coins -= Coins;
        }
    }
}
