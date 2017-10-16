using System.Collections.Generic;

namespace AbstractFactory
{
    public class Maze
    {
        private List<Room> _rooms;

        public Maze()
        {
            this._rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            this._rooms.Add(room);
        }

        public Room RoomNo(int no)
        {
            return this._rooms[no];
        }
    }
}
