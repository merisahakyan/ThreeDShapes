using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalShapes
{
    public abstract class AbstractShapes
    {
        public abstract Point point { get; set; }
        public abstract float Volume();
        public abstract float Area();
    }

    public class Ellipsoid : AbstractShapes
    {
        float a { get; set; }
        float b { get; set; }
        float c { get; set; }

        public override Point point { get; set; }


        public Ellipsoid(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public Ellipsoid()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;

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
    }
}
