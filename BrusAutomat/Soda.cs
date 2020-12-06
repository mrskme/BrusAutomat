using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomat
{
    class Soda
    {
        public enum Types { CocaCola, Solo, Fanta, Pepsi, Water};
        public int Price;
        public Types Type;
        public int Storage;

        public Soda(Types type)
        {
            Type = type;
            if (Type == Types.CocaCola)
            {
                Price = 30;
                Storage = 0;
            }
            if (Type == Types.Solo)
            {
                Price = 20;
                Storage = 2;
            }
            if (Type == Types.Fanta)
            {
                Price = 10;
                Storage = 50;
            }
            if (Type == Types.Pepsi)
            {
                Price = 69;
                Storage = 1;
            }
            if (Type == Types.Water)
            {
                Price = 0;
                Storage = Int32.MaxValue;
            }
        }
    }
}
