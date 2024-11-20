using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	public class Car : Vehicle, Intefaces.ISetSpeed, Intefaces.ISetAmoutOfSeats
	{
		/// <summary>
		/// Класс автомобиль 
		/// </summary>

		// Лошадинные силы
		private int _HorsePower;


		//--------------------------------------------

		// Инкапсуляция 
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



		
		public void SetMaxSpeed(int Speed)
		{
			MaxSpeed = Speed;
		}
		public void SetAmoutOfSeats(int seats)
		{
			Seats = seats;
		}

		

	}
}
