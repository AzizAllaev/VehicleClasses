using ConsoleApp5.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	internal class Plane : Vehicle, Intefaces.IName, Intefaces.IRegistrationNumber 
	{
		/// <summary>
		/// Класс Plane(пассажирский самолет)
		/// </summary>

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


		public void SetRegistrationNumber(string number)
		{
			RegistrationNumber = number;
		}
		public void SetName(string name)
		{
			Name = name;
		}
	}
}
