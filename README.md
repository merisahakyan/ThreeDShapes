###Working with Three dimentional shapes.
Class library **ThreeDimentionalShapes** contains abstract class **AbstractShapes**, which has 3 abstract members: property **point** (_coordinates x,y,z_); **method Volume()** (_which calculates volume of shape_) and **method Area()** (_which calculates area of shape_).
**ThreeDimentionalShapes** contains 2 structures: **Point** (_for determining x,y,z coordinates_) and **MoveDirections** (_for determining axis angles with x,y,z axises_ ) .
We have **IMuveable** interface , which provides shape's moving. It contains methods **MoveTo(),MoveBy(),MoveByAxis()**.
Classes **Ellipsoid** and **Cone** are inherited from **AbstractShape** abstract class and **IMuveable** interface.
For using this class library is necessary to add namespace ThreeDimentionalShapes  :  using ThreeDimentionalShapes;

Here are trial code

```cs
using System;
using ThreeDimentionalShapes;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = (float)Math.PI;

            Ellipsoid e = new Ellipsoid();
            Console.WriteLine($"Ellipsoid \n Volume is equal to {e.Volume()} \n Area is equal to {e.Area()} \n Coordinates are ({e.point.x};{e.point.y};{e.point.z}) \n");

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
```

The result is:


