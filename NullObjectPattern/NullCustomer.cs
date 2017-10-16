namespace NullObjectPattern
{
    public class NullCustomer: AbstractCustomer
    {
        public override bool isNull()
        {
            return true;
        }

        public override string GetName()
        {
            return "Not Available in Customer Database";
        }
    }
}
