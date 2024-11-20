using ConsoleApp5.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	internal class Plane : Vehicle, Intefaces.ISetAmoutOfSeats, Intefaces.ISetSpeed
	{
		

		// У самолёта есть два важных свойства максимальная грузоподъёмность и номер рейса
		private int _Capacity;
		private string _FlightNumber;
		//---------------------------------------------------

		// Инкапсуляция
		public int Capacity
		{
			get
			{
				return _Capacity;
			}
			set
			{
				_Capacity = value;
			}
		}
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


		//---------------------------------------------------


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
