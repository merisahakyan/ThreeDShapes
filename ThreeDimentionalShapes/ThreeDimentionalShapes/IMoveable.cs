using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalShapes
{
    public interface IMoveable
    {
        void MoveTo(float x, float y, float z);
        void MoveTo(Point p);
        void MoveBy(float dx, float dy, float dz);
        void MoveByAxis(MoveDirections md, float d);
    }
}
