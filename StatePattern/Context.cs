namespace StatePattern
{
    public class Context
    {
        public IState state { get; set; }

        public Context()
        {
            state = null;
        }


    }
}
