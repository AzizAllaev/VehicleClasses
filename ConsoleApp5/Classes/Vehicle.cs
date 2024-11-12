using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Classes
{
	public abstract class Vehicle
	{
		/// <summary>
		/// Базовый класс Vehicle(Транспортное средство)
		/// </summary>

		//--------------------------------------------------------------------

		// Любое транспортное средство имеет 2 свойства такие как: имя, регистрацонный номер
		public string RegistrationNumber {  get; set; }
		public string Name {  get; set; }

		
	
	}
}
