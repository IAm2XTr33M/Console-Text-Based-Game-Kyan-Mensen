using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class RoomManager
    {
        public List<Room> rooms = new List<Room>();

        public RoomManager()
        {
            this.createRooms();
        }

        public Room getCurrentRoom(int[] playerPos)
        {
            Room CR = rooms[0];
            for (int i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].pos[0] == playerPos[0] && rooms[i].pos[1] == playerPos[1])
                {
                    CR = rooms[i];
                }
            }

            return CR;
        }

        public void createRooms()
        {
            rooms.Add(new Room("Entrance", new int[] { 0, 0 },
@"I've never seen such a sad entrance.
the only thing here is an old door to the right.
Lets get into the house."));
            rooms[rooms.Count - 1].addDoor("e",false,"0");


            rooms.Add(new Room("Hallway", new int[] { 0, 1 },
@"There's two doors in this room.
It is a 90° turn to the left of the last door.
I wonder if theres actually light in this building."));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("w", false, "0");


            rooms.Add(new Room("First T split", new int[] { 1, 1 },
@"Theres a total of 3 doors in this room.
One on the same side as the door in the first room.
And A red locked door directly on the other side."));
            rooms[rooms.Count - 1].addDoor("e", false, "0");
            rooms[rooms.Count - 1].addDoor("w", true, "r");
            rooms[rooms.Count - 1].addDoor("s", false, "0");


            rooms.Add(new Room("Big hallway", new int[] { 1, 2 },
@"There's doors on every side imaginable.
Sadly the blue and yellow doors are locked.
Yellow is on the oposide side of where we came in.
And blue is a 270° turn to the right from the yellow door."));
            rooms[rooms.Count - 1].addDoor("w", false, "0");
            rooms[rooms.Count - 1].addDoor("s", false, "0");
            rooms[rooms.Count - 1].addDoor("n", true, "b");
            rooms[rooms.Count - 1].addDoor("e", true, "y");


            rooms.Add(new Room("closet", new int[] { 0, 2 },
@"This room looks like a utility closet.
There must be something hidden in here.
Press ENTER to search the room"));
            rooms[rooms.Count - 1].addDoor("n",false , "0");


            rooms.Add(new Room("Hallway", new int[] { 1, 0 },
@"Only thing here is two doors facing north and east.
Lets proceed quickly, I dont like this room."));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("e", false, "0");


            rooms.Add(new Room("Hallway", new int[] { 2, 0 },
@"Theres two doors in here aswell.
It is a 90° turn to the right of the entrance of this room."));
            rooms[rooms.Count - 1].addDoor("s", false, "0");
            rooms[rooms.Count - 1].addDoor("e", false, "0");


            rooms.Add(new Room("Second T split", new int[] { 2, 1 },
@"Theres three doors in this room.
One directly acrosss where you came from.
And the other one facing upwards."));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("e", false, "0");
            rooms[rooms.Count - 1].addDoor("s", false, "0");


            rooms.Add(new Room("Third T split", new int[] { 2, 2 },
@"Theres a blue locked door in the bottom.
This is the same door as before.
Theres one normal door right across the locked blue door"));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("w", false, "0");
            rooms[rooms.Count - 1].addDoor("s", true, "b");


            rooms.Add(new Room("Hallway", new int[] { 3, 2 },
@"This room has two doors.
One of them is a locked blue door.
The doors are in the bottom and right"));
            rooms[rooms.Count - 1].addDoor("e", false, "0");
            rooms[rooms.Count - 1].addDoor("s", true, "b");


            rooms.Add(new Room("Dining room", new int[] { 3, 1 },
@"Only thing here is two doors facing south and opposide of east.
Lets proceed quickly, I dont like this room."));
            rooms[rooms.Count - 1].addDoor("w", false, "0");
            rooms[rooms.Count - 1].addDoor("s", false, "0");


            rooms.Add(new Room("Kitchen", new int[] { 3, 0 },
@"This is a dead end.
But I do feel like there must be something hidden here.
Try searching the room."));
            rooms[rooms.Count - 1].addDoor("e", false, "0");


            rooms.Add(new Room("Math room", new int[] { 3, 3 },
@"Two doors , they are at 593 and 10*3/2+4
-26=N -281=E -19=S -593=W
I feel like something is watching me"));
            rooms[rooms.Count - 1].addDoor("s", false, "0");
            rooms[rooms.Count - 1].addDoor("w", false, "0");


            rooms.Add(new Room("Hallway", new int[] { 2, 3 },
@"Theres one more door in this room.
It is 90° to the right of the door you came in here."));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("e", false, "0");


            rooms.Add(new Room("Big room", new int[] { 2, 4 },
@"One big purple locked door in the north
I feel like this door is important
Theres a lot of chests here, lets search."));
            rooms[rooms.Count - 1].addDoor("n", true, "p");
            rooms[rooms.Count - 1].addDoor("w", false, "0");


            rooms.Add(new Room("Study room", new int[] { 1, 3 },
@"Just two doors in this room.
one in the bottom and one west."));
            rooms[rooms.Count - 1].addDoor("s", false, "0");
            rooms[rooms.Count - 1].addDoor("w", false, "0");


            rooms.Add(new Room("Bedroom", new int[] { 0, 3 },
@"Theres one door in this room other than the entrance.
This door is located on the right s\ide of the room
That bed looks really soft."));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("e", false, "0");


            rooms.Add(new Room("Walk in closet", new int[] { 0, 4 },
@"This room's layout is the same as the bedroom but mirrored.
It is mirrored over the vertical axis (p|q).
Theres so many clothes here"));
            rooms[rooms.Count - 1].addDoor("n", false, "0");
            rooms[rooms.Count - 1].addDoor("w", false, "0");


            rooms.Add(new Room("Bathroom", new int[] { 1, 4 },
@"Theree is A big purple key hanging , try searching the room.
The rest of this room is pretty boring and a dead end."));
            rooms[rooms.Count - 1].addDoor("s", false, "0");


            rooms.Add(new Room("Final room", new int[] { 3, 4 },
@"There is definatly a Ghost here.
Once this ghost is dead I am done."));
            rooms[rooms.Count - 1].addDoor("s", false, "0");


        }
    }
}
