namespace NullObjectPattern
{
    public class RealCustomer: AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override bool isNull()
        {
            return false;
        }

        public override string GetName()
        {
            return this.name;
        }
    }
}
