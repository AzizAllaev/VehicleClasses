using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	public class Car : Vehicle, Intefaces.IName, Intefaces.IRegistrationNumber
	{
		/// <summary>
		/// Класс автомобиль 
		/// </summary>

		private int _HorsePower;
		private int _AmoutOfSeats;

		// Имеет два свойства Л/С, и количество посадочных мест

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
		public int AmoutOfSeats
		{
			get
			{
				return _AmoutOfSeats;
			}
			set
			{
				_AmoutOfSeats = value;
			}
		}

		public void SetName(string name)
		{
			Name = name;
		}
		public void SetRegistrationNumber(string number)
		{
			RegistrationNumber = number;
		}
	}
}
