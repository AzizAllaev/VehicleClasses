using ConsoleApp5.Classes;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Plane plane = new Plane();
			
			Console.Write("Модель самолета: ");
			string PlaneName = Console.ReadLine();
			plane.SetName(PlaneName);
			
			Console.Write("Регистрационный номер: ");
			string Id = Console.ReadLine();
			plane.SetRegistrationNumber(Id);

			Console.Write("Максимальная грузоподъёмность: ");
			string Stringcapacity = Console.ReadLine();
			int capacity = int.Parse(Stringcapacity);
			plane.Capacity = capacity;

			Console.WriteLine($"Модель: {plane.Name} | Рег. Номер: {plane.RegistrationNumber} | Макс. Подъем: {plane.Capacity}");



			Console.ReadLine();
		}
	}
}
