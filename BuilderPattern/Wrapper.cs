using System;

namespace BuilderPattern
{
    public class Wrapper: IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
