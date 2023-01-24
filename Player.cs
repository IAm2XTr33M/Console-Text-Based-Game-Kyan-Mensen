using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class Player
    {
        public string name;

        public int health = 10;

        public int[] pos = {0, 0};

        public List<Key> collectedKeys = new List<Key>();

        public void changeHealth(int a)
        {
            this.health += a;
        }

        public void setName(string n)
        {
            this.name = n;
        }

        public void changePos(int a, int b)
        {
            this.pos[0] += a;
            this.pos[1] += b;
        }

        public void addKey(string c)
        {
            collectedKeys.Add(new Key(c));
        }
    }
}
