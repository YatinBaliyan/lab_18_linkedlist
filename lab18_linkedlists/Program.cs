using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab18_linkedlists
{

	public class Program
	{
		/*
		 * create a void RemoveAll (Object o) method, it should remove all occurences
		 * of Object o from the list.
		 * find occurence of an object - DONE
		 * remove occurence - DONE
		 * keep doing it until there arent anymore - DONE
		 * 
		 * remove an object at a specified index - DONE
		 * 
		 * design an algorithim that counts the occurences of numbers in an array.
		 * removes object at specified index - DONE.
		 * ^use an array to find the frequency of each number in the array. - DONE */

		static void Main(string[] args)
		{
			MyList alist = new MyList();
			alist.Add("mango");
			alist.Add("apple");
			alist.Add("kiwi");
			alist.Add("mango");
			alist.Add("strawberry");
			alist.Add("mango");

			Console.WriteLine("------Original List-----");   
            alist.Print();
            
			object o = "mango";
            // remove 3 mangoes
			alist.RemoveAll(o);

			Console.WriteLine($"-----List after removing {o}-----");
			alist.Print();    

            // remove apple
			alist.Remove(0);
			Console.WriteLine($"-----List after removing the first index-----");

			alist.Print(); 


			// Task 2a
            Console.WriteLine("\nTask 2a");
			MyArray arr = new MyArray();
   			int[] entriesCount = arr.CountEntries();
			for (int i = 0; i < entriesCount.Length; i++)
			{
				if (entriesCount[i] >= 0)
					Console.WriteLine($"[{i}]: {entriesCount[i]} ");
			}
		}
	}
}
