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

        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Red, new Point((int)_v1.x + 250, (int)_v1.y + 250), new Point((int)_v2.x + 250, (int)_v2.y + 250));
            g.DrawLine(Pens.Red, new Point((int)_v2.x + 250, (int)_v2.y + 250), new Point((int)_v3.x + 250, (int)_v3.y + 250));
            g.DrawLine(Pens.Red, new Point((int)_v3.x + 250, (int)_v3.y + 250), new Point((int)_v4.x + 250, (int)_v4.y + 250));
            g.DrawLine(Pens.Red, new Point((int)_v4.x + 250, (int)_v4.y + 250), new Point((int)_v1.x + 250, (int)_v1.y + 250));
        }
    }
}
