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
		private MatrixFactory mfactory;
        private int stateCounter;
        
        public Form1() {
			mfactory = new MatrixFactory();
			InitializeComponent();

            stateCounter = 1;
            square = new Square(200);
	        Matrix s = mfactory.createRotation(60) * mfactory.scale(0.5) *
						mfactory.Translate(new Vector(69, 69, 0, 1));
			square.ExecuteMatrix(s);
        }

        private void Scale(double scale){
	        Matrix matrix = mfactory.scale(scale);

            square.ExecuteMatrix(matrix);

            panel1.Invalidate();
        }

        private void Translate(Vector t){
	        Matrix matrix = mfactory.Translate(t);

            square.ExecuteMatrix(matrix);

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
            switch (stateCounter)
            {
                case 1:
                    Scale(0.75);
                    stateCounter++;
                    break;
                case 2:
                    rotate(25);
                    stateCounter++;
                    break;
                case 3:
                    Translate(new Vector(25, 50, 0, 1));
                    stateCounter = 1;
                    break;
            }
        }

		private void rotate(double degrees){
			double radians = (Math.PI / 180) * degrees;
			square.ExecuteMatrix(mfactory.createRotation(degrees));

            panel1.Invalidate();
		}

	}
}