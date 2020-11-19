using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Character
    {
        public string name;
        public int cats;
        public int dog;
        public Item medal;

        public Character()
        {
            name = "";
            cats = 0;
            dog = 0;
            medal = new Item();
        }
        public Character(string playername)
        {
            name = playername;
        }
    }
}
