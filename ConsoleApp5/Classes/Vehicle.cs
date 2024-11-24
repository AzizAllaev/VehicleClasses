using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	/// <summary>
	/// Представляет транспортное средство 
	/// </summary>
	public abstract class Vehicle
	{
		/// <summary>
		/// Максимальная скорость движения
		/// </summary>
		public int MaxSpeed { get; set; }
		
		/// <summary>
		/// Количевство посадочных мест
		/// </summary>
		public int Seats { get; set; }
	}
}
