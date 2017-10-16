namespace BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 50.5f;
        }
    }
}
