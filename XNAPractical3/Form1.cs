using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transform;
namespace XNAPractical3 {
	public partial class Form1 : Form {
        private Square square;
        
        public Form1() {
			InitializeComponent();

            square = new Square(100);
		}

        private void Scale()
        {
            square = new Square(10);

            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(Pens.Black, new Point(10, 250), new Point(490, 250));
            g.DrawLine(Pens.Black, new Point(250, 10), new Point(250, 490));

            square.Draw(g);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Scale();
        }

		private Matrix rotate(double degrees){
			return new Matrix();
		}

	}
}