using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class Room
    {
        public string name;
        public string desc;

        public int[] pos;

        public List<Door> doors = new List<Door>();

        public Room(string n, int[] p, string d)
        {
            this.name = n;
            this.pos = p;
            this.desc = d;
        }

        public void addDoor(string s,bool l, string c)
        {
            doors.Add(new Door(s, l, c));
        }

        public bool isDoor(string input , Player player)
        {
            for (int i = 0; i < doors.Count; i++)
            {
                if(doors[i].side.ToLower() == input.ToLower())
                {
                    if(!doors[i].locked)
                    {
                        return true;
                    }
                    else
                    {
                        for (int o = 0; o < player.collectedKeys.Count; o++)
                        {
                            if (doors[i].color.ToLower() == player.collectedKeys[o].color.ToLower())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
