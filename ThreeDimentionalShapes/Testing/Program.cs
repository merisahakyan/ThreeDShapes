using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeDimentionalShapes;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = (float)Math.PI;

            Ellipsoid e = new Ellipsoid();
            Console.WriteLine($"Ellipsoid with sizes 1,1,1 \n Volume is equal to {e.Volume()} \n Area is equal to {e.Area()} \n Coordinates are ({e.point.x};{e.point.y};{e.point.z}) \n");

            e.MoveTo(2.3f, 4.3f, 1f);
            Console.Write($"After apply method MoveTo, ");
            e.PrintPosition();

            e.MoveBy(-2.3f, -4.3f, -1f);
            Console.Write($"After apply method MoveBy,");
            e.PrintPosition();

            MoveDirections md = new MoveDirections(0, pi/2, pi/2);
            e.MoveByAxis(md, 3);
            Console.Write($"After apply method MoveByAxis, moving ellipsoid by X axis ");
            e.PrintPosition();

            



        }
    }
}
