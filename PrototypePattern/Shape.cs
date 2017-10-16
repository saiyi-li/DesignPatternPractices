using System;

namespace PrototypePattern
{
    public abstract class Shape : ICloneable
    {
        public string id { get; set; }
        protected string type;

        public abstract void Draw();

        public string GetType()
        {
            return type;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return clone;
        }
    }
}
