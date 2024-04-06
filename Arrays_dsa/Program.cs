using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_dsa
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[3] { 1, 2, 3 };
			OurArray our = new OurArray(); 
			our.Resiz<int>( ref arr, 100);
			Console.WriteLine(string.Join(", ", arr));
			Console.ReadLine();
		}
	}
	class OurArray
	{
		public void Resiz<T>( ref T[] source , int newSize)
		{
			if (newSize <= 0) return;
			if(source==null)return;
			if (source.Length == newSize) return;
			T[] newArray = new T[newSize];
			Buffer.BlockCopy(source, 0, newArray, 0, Buffer.ByteLength(source));

			source = newArray;
		}
	}
}
