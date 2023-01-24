using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class GhostManager
    {
        public List<int[]> ghosts = new List<int[]>();

        public GhostManager(int GhostAmmount)
        {
            Random random = new Random();

            int[] finalRoom = { 3, 4 };

            this.ghosts.Add(finalRoom);

            for (int i = 0; i < GhostAmmount-1; i++)
            {
                getRandomRoom();
            }

            void getRandomRoom()
            {
                int[] randomRoom = { random.Next(4), random.Next(5) };

                if (randomRoom[0] == 0 && randomRoom[1] == 0)
                {
                    randomRoom = null;
                }
                else
                {
                    if (this.ghosts.Contains(randomRoom))
                    {
                        randomRoom = null;
                    }
                }

                if (randomRoom != null)
                {
                    this.ghosts.Add(randomRoom);
                }
                else
                {
                    getRandomRoom();
                }
            }
        }

        public void removeGhost(int[] pos)
        {
            for (int i = 0; i < this.ghosts.Count; i++)
            {
                if (ghosts[i][0] == pos[0] && ghosts[i][1] == pos[1])
                {
                    ghosts.RemoveAt(i);
                    i = this.ghosts.Count;
                }
            }
        }

        public bool checkGhost(int[] pos)
        {
            for (int i = 0; i < this.ghosts.Count; i++)
            {
                if(ghosts[i][0] == pos[0] && ghosts[i][1] == pos[1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
