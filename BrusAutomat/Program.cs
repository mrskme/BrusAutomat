using System;

namespace BrusAutomat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementer en brusautomat. Ulike drikker har ulik pris.
            //Automaten har en lagerbeholdning. Man kan putte på mynter (1kr, 5kr, 10kr, 20kr).
            //Man trykker på en knapp for en bestemt drikk
            //-hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
            //Det finnes en knapp for å få gjeldende saldo tilbake.
            SodaMachine sodaMachine = new SodaMachine();
            sodaMachine.InsertMoney(30);
            var chosenType = Soda.Types.Water;
            sodaMachine.ChoseSoda(new Soda(chosenType));
            sodaMachine.ReturnMoney();
        }
    }
}
