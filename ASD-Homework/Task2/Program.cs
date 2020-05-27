using System;
/*Трябва да създадем програма за записване на складова наличност.
Потребителя въвежда продукт и количество в следния формат:
{product} -> {quantity}
След като въведе end, програмата трябва да изпише наличността на всички продукти
сортирана нисходящо по количество.
*/
namespace Task2
{
    class Program
    {
		static void Main(string[] args)
		{

			string input;

			do
			{
				Console.WriteLine("Enter the product and quantity, or \"end\"");
				input = Console.ReadLine();
				String[] Splitted = input.Split(" ");
				if (input == "end")
				{
					break;
				}
				try
				{
					new Product(Splitted[0], Splitted[1]);
				}
				catch (Exception ArgumentOutOfRangeException)
				{
					continue;
				}


			} while (input != "end");


			Product.BubbleSort(Product.Products);

			foreach (Product i in Product.Products)
			{
				i.PrintInfo();
			}
		}	
    }
}
	