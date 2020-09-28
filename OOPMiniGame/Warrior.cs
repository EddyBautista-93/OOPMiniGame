using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMiniGame
{
    class Warrior
    {

        public string Name { get; set; } = "Warrior";

        public double Health { get; set; } = 0;

        public double AttkMax { get; set; } = 0;

        public double BlockMax { get; set; } = 0;

        Random rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0)
        {
            this.Name = name;
            this.Health = health;
            this.AttkMax = attkMax;
            this.BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }



    }
}
