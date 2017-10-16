namespace Builder
{
    public class Room : MapSite
    {
        private MapSite[] _sides;
        private int _roomNumber;

        public Room(int roomNumber)
        {
            this._roomNumber = roomNumber;
            this._sides = new MapSite[4];
        }

        public override void Enter()
        {

        }

        public MapSite GetSide(Direction direction)
        {
            return this._sides[(int) direction];
        }

        public void SetSide(Direction direction, MapSite side)
        {
            this._sides[(int) direction] = side;
        }
    }
}
