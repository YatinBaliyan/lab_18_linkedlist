using System;

namespace lab18_linkedlists
{
    public class Node
    {
		
		private object data;
        //references next node in list
		private Node next;
        
        //constructor
		public Node (object data, Node next)
		{
			this.data = data;
			this.next = next;
		}

        //property
        public object Data
		{
			get { return this.data; }
			set { this.data = value; }
		}

		public Node Next
		{
			get { return this.next; }
			set { this.next = value; }
		}

        //print method
        public void Print()
		{
			Console.WriteLine(data);

            if (next != null)
			{
				next.Print();
			}

		}

        public Node()
        {
        }
    }
}