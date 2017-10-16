namespace Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        private int _rooms;
        private int _doors;

        public CountingMazeBuilder()
        {
            this._rooms = this._doors = 0;
        }

        public override void BuildRoom(int roomt)
        {
            this._rooms++;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            this._doors++;
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = this._rooms;
            doors = this._doors;
        }

        public virtual void AddWall(int r, Direction direction)
        {
            
        }
    }
}
