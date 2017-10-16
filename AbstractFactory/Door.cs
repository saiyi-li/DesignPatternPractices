using System.Security.Cryptography;

namespace AbstractFactory
{
    public class Door : MapSite
    {
        private readonly Room _r1;
        private readonly Room _r2;
        private bool _isOpen;

        public Door(Room r1, Room r2, bool isOpen = false)
        {
            this._r1 = r1;
            this._r2 = r2;
            _isOpen = isOpen;
        }

        public MapSite OtherSideFrom(Room r)
        {
            if (r == this._r1)
                return this._r2;
            else if (r == this._r2)
                return this._r1;
            else
                return null;
        }

        public override void Enter()
        {
            
        }
    }
}
