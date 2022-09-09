using System;

namespace Home5Task3
{
	/// <summary>
	/// В цьому завданні допоміг інтернет, бо не зразу зрозумів як реалізувати. але ніби розібрався. 
	/// </summary>
	class Printer
	{
		public virtual void Print(string value)
		{
			Console.WriteLine($"Кольоровий друк : {value} ");
		}
	}

	class ColorPrinter : Printer
	{
		private ConsoleColor color;

		public ColorPrinter(ConsoleColor color)
		{
			this.color = color;
		}

		public override void Print(string value)
		{
			Console.Write("Кольоровий друк //");
			Console.Write(color);
			Console.Write("//: ");
			Console.ForegroundColor = color;
			Console.WriteLine(value);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}

	internal class Program
    {
        /*Задание 5

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создайте класс Printer. 
        В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента. 
        Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове 
        соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами. 
        Обязательно используйте приведение типов.*/


        static void Main(string[] args)
        {
			Printer yellColorPrint = new ColorPrinter(ConsoleColor.Yellow);
			TestPrinter(yellColorPrint);

			Printer monoPrint = new Printer();
			TestPrinter(monoPrint);
		}
		static void TestPrinter(Printer p)
		{
			p.Print("друк");
		}
	}
}
