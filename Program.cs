using System;

namespace FinalConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineSpeed = 99;
            int ghostAmmount = 10;

            LineWriter lineWriter = new LineWriter(lineSpeed);
            Player player = new Player();
            RoomManager roomManager = new RoomManager();
            InputHandler input = new InputHandler();
            GhostManager ghostManager = new GhostManager(ghostAmmount);
            Texthandler textHandler = new Texthandler(lineSpeed, player, ghostManager , roomManager);


            textHandler.text(1);
            player.setName(Console.ReadLine());

            textHandler.text(2);
            input.getEnter();

            textHandler.text(3);
            input.getEnter();

            startRound();

            textHandler.text(5);
            input.getEnter();

            Environment.Exit(0);


            void startRound()
            {
                if(player.pos[0] == 0 && player.pos[1] == 0 && ghostManager.ghosts.Count == 0)
                {
                    return;
                }

                textHandler.text(4);

                input.getInput(roomManager.getCurrentRoom(player.pos) , player,ghostManager);

                startRound();
            }
        }
    }
}
