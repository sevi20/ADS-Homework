using System;
/*Създайте програма, която от въведен текст изкарва думите които се повтарят нечетен брой пъти*/
namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr1 = new int[10];

			Random rand = new Random();


			for (int i = 0; i < arr1.Length; i++)
			{
				arr1[i] = rand.Next(100);
			}
			int[] arr2 = new int[10];

			CopyTo(arr1, arr2);
			PrintArray(arr2);

			Console.Write(" Array 2 ");
			PrintArray(arr1);
			PrintAverage(arr1);
			FindMin(arr1);
			Console.WriteLine(" Enter the number ");
			int input = int.Parse(Console.ReadLine());

			Console.WriteLine(FindInArray(arr1, input));

		}

		static void PrintArray(int[] arr)
		{
			Console.Write("{ ");
			foreach (int j in arr)
			{
				Console.Write(j + " ");
			}

			Console.WriteLine("}");
		}

		static void PrintAverage(int[] arr)
		{
			int count = 0;
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				count++;
			}

			Console.WriteLine(" Average: " + (double)sum / count);
		}

		static int FindInArray(int[] arr, int num)
		{
			int index = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == num)
				{
					index = i;
					break;
				}
			}

			return index;
		}

		static void FindMin(int[] arr)
		{
			int lastmin = int.MaxValue;
			int min = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}

			}

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < lastmin && arr[i] > min)
				{
					lastmin = arr[i];
				}

			}
			Console.WriteLine(" The second smallest number is: " + lastmin + " and at least is: " + min);
		}

		static void CopyTo(int[] arrA, int[] arrB)
		{
			for (int i = 0; i < arrA.Length; i++)
			{
				arrB[i] = arrA[i];
			}
		}
	}
}

