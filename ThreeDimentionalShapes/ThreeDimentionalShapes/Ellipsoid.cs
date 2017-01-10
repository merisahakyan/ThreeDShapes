using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalShapes
{
    public class Ellipsoid : AbstractShapes,IMoveable
    {
        float a { get; set; }
        float b { get; set; }
        float c { get; set; }
        public override Point point { get; set; }


        public Ellipsoid()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
            this.point = new Point();
        }
        public Ellipsoid(float a, float b, float c, Point p)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.point = p;
        }

        
        public override float Area()
        {
            float p = 1.6075f;
            return (float)(4 * Math.PI * Math.Pow((Math.Pow(a * b, p) + Math.Pow(a * c, p) + Math.Pow(b * c, p)) / 3, 1 / p));
        }

        public override float Volume()
        {
            return 4f / 3 * (float)Math.PI * a * b * c;
        }

        public void MoveTo(float x, float y, float z)
        {
            Point p = new Point();
            p.x = x;
            p.y = y;
            p.z = z;
            this.point = p;
        }

        public void MoveTo(Point p)
        {
            this.point = p;
        }

        public void MoveBy(float dx, float dy, float dz)
        {
            Point p = new Point();
            p.x = point.x + dx;
            p.y = point.y + dy;
            p.z = point.z + dz;
            this.point = p;
        }

        public void MoveByAxis(MoveDirections md, float d)
        {
            Point p = new Point();
            p.x = this.point.x + d * (float)Math.Cos(md.alpha);
            p.y = this.point.y + d * (float)Math.Cos(md.betta);
            p.z = this.point.z + d * (float)Math.Cos(md.gamma);
            this.point = p;
        }
    }
}
