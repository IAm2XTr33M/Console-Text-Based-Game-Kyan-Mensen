using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class Door
    {
        public string side;
        public string color;
        public bool locked;

        public Door(string s, bool l, string c)
        {
            this.side = s.ToLower();
            this.locked = l;
            this.color = c.ToLower();
        }
    }
}
