using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transform;

namespace XNAPractical3 {
	class MatrixFactory {

		Matrix createRotation(double degrees){
			double radians = (Math.PI / 180) * degrees;
			return new Matrix(
				new double[,]{
					{Math.Cos(radians), Math.Sin(radians), 0, 0},
					{-Math.Sin(radians), Math.Cos(radians), 0, 0},
					{0, 0, 1, 0},
					{0, 0, 0, 1}
				}
				);
		}
        public Matrix scale(double scale)
        {
            return new Matrix(new double[,]{
                {scale, 0, 0, 0},
                {0, scale, 0, 0},
                {0, 0, scale, 0},
                {0, 0, 0, 1}
            });
	}
}
