using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transform {
	public class Vector {
		double x { get; set; }
		double y { get; set; }
		private double _z;
		double z { get; set; }

		private double w{
			get{
				return _z;
			}
			set{
				double newValue = value;
				if(value < 0){
					newValue = 0;
				}
				if(value > 1){
					newValue = 1;
				}
				_z = newValue;
			}
		}

		public Vector(){
			x = 0;
			y = 0;
			z = 0;
			w = 0;
		}
		public Vector(double px, double py, double pz, double pw){
			x = px;
			y = py;
			z = pz;
			w = pw;
		}

		double sum(){
			return x + y + z + w;
		}

		public static Vector operator +(Vector lhs, Vector rhs){
			Vector result = new Vector();
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;
			result.w = lhs.w + rhs.w;
			return result;
		}
		public static Vector operator -(Vector lhs, Vector rhs){
			Vector result = new Vector();
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			result.w = lhs.w - rhs.w;
			return result;
		}
		public static double operator *(Vector lhs, Vector rhs){
			Vector result = new Vector();
			result.x = lhs.x * rhs.x;
			result.y = lhs.y * rhs.y;
			result.z = lhs.z * rhs.z;
			result.w = lhs.w * rhs.w;
			return result.sum();
		}

		public override string ToString(){
			string result = "";
			result += x + "\n";
			result += y + "\n";
			result += z + "\n";
			result += w + "\n";
			return result;
		}
	}
}
