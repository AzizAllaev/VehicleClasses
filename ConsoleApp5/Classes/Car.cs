using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	/// <summary>
	/// Представляет автомобиль
	/// </summary>
	public class Car : Vehicle, Intefaces.ISetSpeed, Intefaces.ISetAmoutOfSeats
	{
		/// <summary>
		/// Мощность двигателя
		/// </summary>
		private int _HorsePower;
		
		public int HorsePower
		{
			get
			{
				return _HorsePower;
			}
			set
			{
				_HorsePower = value;
			}
		}

		/// <summary>
		/// Присваивание свойства максимальной скорости 
		/// </summary>
		/// <param name="Speed"></param>
		public void SetMaxSpeed(int Speed)
		{
			MaxSpeed = Speed;
		}
		/// <summary>
		/// Присваивание свойства количества посадочных мест
		/// </summary>
		/// <param name="seats"></param>
		public void SetAmoutOfSeats(int seats)
		{
			Seats = seats;
		}
	}
}
