using ConsoleApp5.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	/// <summary>
	/// Представляет гражданский пассажрский самолёт
	/// </summary>
	internal class Plane : Vehicle, Intefaces.ISetAmoutOfSeats, Intefaces.ISetSpeed
	{
		/// <summary>
		/// Номер рейса 
		/// </summary>
		private string _FlightNumber;

		public string FlightNumber
		{
			get
			{
				return _FlightNumber;
			}
			set
			{
				_FlightNumber = value;
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
