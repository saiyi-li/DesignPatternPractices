namespace Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        {
        }

        public Direction CommonWall(Room r1, Room r2)
        {
            
        }

        public virtual void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public virtual void BuildRoom(int n)
        {
            if (_currentMaze.RoomNo(n) != null) {
                Room room = new Room(n);
                _currentMaze.AddRoom(room);
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public virtual void BuildDoor(int n1, int n2)
        {
            Room rl = _currentMaze.RoomNo(n1);
            Room r2 = _currentMaze.RoomNo(n2);
            Door d = new Door(rl, r2);
            rl.SetSide(CommonWall(rl, r2), d);
            r2.SetSide(CommonWall(r2, rl), d);
        }

        public virtual Maze GetMaze()
        {
            return _currentMaze;
        }
        
    }
}
