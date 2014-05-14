using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transform;

namespace XNAPractical3
{
    class Square
    {
        private int _size;
        private Vector _v1, _v2, _v3, _v4;

        public Square(int size)
        {
            _size = size;
            _v1 = new Vector(-size / 2, -size / 2, 0, 1);
            _v2 = new Vector(size / 2, -size / 2, 0, 1);
            _v3 = new Vector(size / 2, size / 2, 0, 1);
            _v4 = new Vector(-size / 2, size / 2, 0, 1);
        }

        private void Paint(Graphics g)
        {
            g.DrawLine(Pens.Red, new Point((int)_v1.x, (int)_v1.y), new Point((int)_v2.x, (int)_v2.y));
        }
    }
}
