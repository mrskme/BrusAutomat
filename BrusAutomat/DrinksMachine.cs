using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrusAutomat
{
    class DrinksMachine
    {
        private int _coins;
        private List<DrinksType> Drinks;

        public DrinksMachine()
        {
            Drinks = new List<DrinksType>
            {
                new DrinksType(30, "Solo", 20),
                new DrinksType(33, "Burn", 10),
                new DrinksType(25, "Coca Cola", 5),
                new DrinksType(10, "Water", 2),
                new DrinksType(80, "Urge", 1),
            };
        }
        public void ChoseDrink(string type)
        {
            var chosenType = Drinks.FirstOrDefault(D => D.Name == type);
            if (chosenType != null) GiveDrinkToHuman(chosenType);
            else Console.WriteLine($"{type} is not a valid drink\n");
            //metode som returnerer drinks type
        }

        public void GiveDrinkToHuman(DrinksType chosenType)
        {
            string output;
            Console.WriteLine($"You have chosen {chosenType.Name}");
            if (chosenType.Storage > 0)
            {
                if (chosenType.Price <= _coins)
                {
                    _coins -= chosenType.Price;
                    chosenType.Storage--;
                    output = $"A {chosenType.Name} was violently dropped to the tray at the bottom\n" +
                             $"The machine has {chosenType.Storage} {chosenType.Name}s left\n" +
                             $"You have {_coins} coins left"; ;
                }
                else output =  $"Insert {chosenType.Price - _coins} more coins for a {chosenType.Name}";
            }
            else output = $"The machine is out of {chosenType.Name}";
            Console.WriteLine($"{output}\n");
        }

        public void ReturnMoney()
        {
            Console.WriteLine($"{_coins} was blurted out");
            _coins -= _coins;
        }

        public void InsertMoney(int amount)
        {
            _coins += amount;
        }
    }
}
