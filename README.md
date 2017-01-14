###Working with Three dimentional shapes. </br>
Class library **ThreeDimentionalShapes** contains abstract class **AbstractShapes**, which has 3 abstract members: **property point** (_coordinates x,y,z_); **method Volume()** (_which calculates volume of shape_) and **method Area()** (_which calculates area of shape_). </br>
```cs
public abstract class AbstractShapes
{
    public abstract Point point { get; set; }
    public abstract float Volume();
    public abstract float Area();
}
```
**ThreeDimentionalShapes** contains 2 structures: **Point** (_for determining x,y,z coordinates_) and **MoveDirections** (_for determining axis angles with x,y,z axises_ ) .</br>
The struct **MoveDirections** allows you to determine any axis in distance with 3 arguments: alpha (angle of given and x axis), betta (for given and y axis) , gamma (for given and z axis).
```cs
public struct Point
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public Point(float x,float y,float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
  
public struct MoveDirections
{      
       public float alpha { get; set; }
       public  float betta { get; set; }
       public  float gamma { get; set; }
        public MoveDirections(float a,float b,float c)
        {
            alpha = a;
            betta = b;
            gamma=c;
        }
} 
```
We have **IMuveable** interface , which provides shape's moving. It contains methods **MoveTo(),MoveBy(),MoveByAxis()**.</br>
* Method **MoveTo()** allows you to move the shape to given location.</br>
* Method **MoveBy()** allows you to move the shape by given difference coordinates dx,dy,dz.</br>
* Method **MoveByAxix()** allows you to move shape by any axis in distance with 2 arguments.Float d is the length of locomotion by given axis</br>


```cs
public interface IMoveable
{
    void MoveTo(float x, float y, float z);
    void MoveTo(Point p);
    void MoveBy(float dx, float dy, float dz);
    void MoveByAxis(MoveDirections md, float d);
}
```
Classes **Ellipsoid** and **Cone** are inherited from **AbstractShape** abstract class and **IMuveable** interface.</br>
For using this class library is necessary to add namespace ThreeDimentionalShapes  :  using ThreeDimentionalShapes;</br>

###Here are trial code</br>

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
```


###The result is: </br>
![result](https://github.com/marysahakyan/ThreeDShapes/blob/master/shapes.png)



