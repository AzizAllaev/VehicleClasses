using ConsoleApp5.Classes;
using ConsoleApp5.Intefaces;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car Lacetti = new Car();
			Lacetti.MaxSpeed = 180;
			Console.Write("Сколько посадочных мест в Lacetti: ");
			string StringAmoutOfseats = Console.ReadLine();
			int AmoutOfSeats = Convert.ToInt32(StringAmoutOfseats);
			Lacetti.SetAmoutOfSeats(AmoutOfSeats);

			Console.WriteLine($"Количевство посадочных мест: {Lacetti.Seats} || Максимальная скорость: {Lacetti.MaxSpeed}");

			Console.ReadLine();
		}
	}
}
