using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Transform
{
	public delegate void receiveCoordinatedDataMember(int x, int y, double value);
	public delegate void receiveDataMember(ref double value);
	public class Matrix{

		public double[,] data{
			get; set; 
		}

		public Matrix() : this(new double[4, 4]){
			ForEach( delegate(ref double value){
				value = 0;
			});
			for(int y = 0; y < 4; y++){
				for(int x = 0; x < 4; x++){
					data[x,y] = 0;
				}
			}
		}

		public Matrix(double[,] data){
			this.data = data;
		}

		public double sum(){
			double result = 0;
			ForEach(delegate(ref double value) {
				result += value;
			});
			return result;
		}
		public override String ToString(){
			String result = "";
			ForEach(delegate(int x, int y, double value){
			int prevY = 0;
				if(x == 0){
					result += "\n";
				}
				result += value + ",";

			});
			return result;
		}

		public void ForEachInColl(int x,receiveDataMember closure){
			for(int y = 0; y < data.GetLength(1); y++){
				closure(ref data[y, x]);
			}
		}
		public void ForEachInRow(int y,receiveDataMember closure){
			for(int x = 0; x < data.GetLength(0); x++){
				closure(ref data[y, x]);
			}
		}
		public void ForEach(receiveDataMember closure){
			for(int y = 0; y < data.GetLength(1); y++){
				for(int x = 0; x < data.GetLength(0); x++){
					closure(ref data[y,x]);
				}
			}
		}
		public void ForEach(receiveCoordinatedDataMember closure){
			for(int y = 0; y < data.GetLength(1); y++){
				for(int x = 0; x < data.GetLength(0); x++){
					closure(x, y, data[y,x]);
				}
			}
		}
		public static Matrix operator +(Matrix lhs, Matrix rhs){
			Matrix result = new Matrix();
			lhs.ForEach(
			delegate(int x, int y, double value) {
				result.data[y,x] = value + rhs.data[y,x];
			});
			return result;
		}
		public static Matrix operator -(Matrix lhs, Matrix rhs){
			Matrix result = new Matrix();
			lhs.ForEach(
			delegate(int x, int y, double value) {
				result.data[y,x] = value - rhs.data[y,x];
			});
			return result;
		}
		public static Matrix operator *(Matrix lhs, Matrix rhs){
			Matrix result = new Matrix();
			lhs.ForEach(
			delegate(int x, int y, double value){
				int i = 0;
				rhs.ForEachInRow(x, delegate(ref double one){
					result.data[x,y] += one * lhs.data[i,y];
					i++;
				});
			});
			return result;
		}

		public static Matrix operator *(Matrix lhs, double rhs){
			Matrix result = new Matrix();
			lhs.ForEach(
			delegate(int x, int y, double value) {
				result.data[y,x] = value * rhs;
			});
			return result;
		}

		public static Matrix operator *(double lhs,
			Matrix rhs){
			return rhs * lhs;
		}

		public static Vector operator *(Matrix lhs, Vector rhs){
			Vector result = new Vector();
			lhs.ForEach(delegate(int x, int y, double value) {
				result[y] += rhs[x] * value;
			});
			return result;
		}

	}
}
