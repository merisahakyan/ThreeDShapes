using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalShapes
{
    public class Cone : AbstractShapes,IMoveable
    {
        float radius { get; set; }
        float height { get; set; }

        public override Point point { get; set; }

        public Cone()
        {
            this.radius = 1f;
            this.height = 1f;
            this.point = new Point();
        }


        public Cone(float radius,float height,Point p)
        {
            this.radius = radius;
            this.height = height;
            this.point = p;
        }

        public override float Volume()
        {
            return 1f / 3 * (float)Math.PI * (float)Math.Pow(radius, 2) * height;
        }

        public override float Area()
        {
            float l = (float)Math.Sqrt((Math.Pow(radius, 2) + Math.Pow(height, 2)));
            return ((float)Math.PI * (float)Math.Pow(radius, 2) + (float)Math.PI * radius * l);
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
