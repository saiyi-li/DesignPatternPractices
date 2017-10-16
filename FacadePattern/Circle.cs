using System;
using System.CodeDom;

namespace FacadePattern
{
    public class Circle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle: Draw()");
        }
    }
}
