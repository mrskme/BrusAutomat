using System;

namespace BrusAutomat
{
    class Program
    {
        
        static void Main(string[] args)
        { 
            SodaMachine sodaMachine = new SodaMachine(); 
            SodaFactory sodaFactory = new SodaFactory();
        //Implementer en brusautomat. Ulike drikker har ulik pris.
        //Automaten har en lagerbeholdning. Man kan putte på mynter (1kr, 5kr, 10kr, 20kr).
        //Man trykker på en knapp for en bestemt drikk
        //-hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
        //Det finnes en knapp for å få gjeldende saldo tilbake.

            sodaFactory.MakeSoda(Soda.Types.Fanta, 20);
            sodaFactory.MakeSoda(Soda.Types.CocaCola, 1);
            sodaFactory.MakeSoda(Soda.Types.Solo, 0);
            sodaFactory.MakeSoda(Soda.Types.Pepsi, 4);
            sodaFactory.MakeSoda(Soda.Types.Water, 3);


            sodaMachine.InsertMoney(200);

            //var chosenType1 = Soda.Types.Pepsi;
            //sodaMachine.ChoseSoda(new Soda(chosenType1));

            //var chosenType2 = Soda.Types.Solo;
            //sodaMachine.ChoseSoda(new Soda(chosenType2));

            var chosenType3 = Soda.Types.Solo;
            sodaMachine.ChoseSoda(new Soda(chosenType3));

            sodaMachine.ReturnMoney();
        }
    }
}
