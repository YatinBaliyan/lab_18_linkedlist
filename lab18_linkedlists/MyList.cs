using System;
namespace lab18_linkedlists
{
	public class MyList
	{
		//fields 
		private Node headNode;
		public int count;
		//private Node current;

		//constructor that initializes the fields
		public MyList()
		{
			//current = null;
			headNode = null;
			count = 0;
		}


		// property, returns true if size == 0
		public bool Empty
		{
			get { return this.count == 0; }
		}



		public int Count
		{
			get { return this.count; }
			set { this.count = value; }
		}


		// simply add an object
		public object Add(object o)
		{
			return this.Add(count, o);
		}


		public object Add(int index, object o)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("Index:" + index);
			}
			if (index > count)
			{
				index = count;
			}
			Node current = this.headNode;

			if (this.Empty || index == 0)
			{
				this.headNode = new Node(o, this.headNode);
			}
			else
			{
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}
				current.Next = new Node(o, current.Next);
			}
			count++;

			return o;
		}



		// removes at specified index, if it does not exist it will return false;
		public object Remove(int index)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("Index: " + index);
			}
			if (this.Empty)
			{
				return null;
			}
			if (index > this.count)
			{
				index = count - 1;

			}
			Node current = this.headNode;
			object result = null;

			if (index == 0)
			{
				result = current.Data;
				this.headNode = current.Next;
			}
			else
			{
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}

				result = current.Next.Data;

				current.Next = current.Next.Next;

			}
			count--;

			return result;
		}

		//print the list
		public void Print()
		{
			if (headNode != null)
			{
				headNode.Print();
			}
		}

		public void RemoveAll(object o)
		{
            Node nodeVisitor = headNode;
			if (Count == 1 && headNode.Data ==o)
            {
                //back to an empty list
                headNode = null;
                nodeVisitor = null;
                Count = 0;
            }

			if (Count > 1 && headNode.Data == o)
			{
				headNode = headNode.Next;
			}


			Node prevVisitor = null;
			nodeVisitor = headNode;

			while (nodeVisitor != null)
			{
				if (nodeVisitor.Data == o)
				{
					prevVisitor.Next = nodeVisitor.Next;
				}

				else
				{
					prevVisitor = nodeVisitor;
				}
				nodeVisitor = prevVisitor.Next;
			}
		}

		public void RemoveFromStart()
        {
			if (Count > 1)
            {
                headNode = headNode.Next;
            }
            else
            {
                //really we want to throw an exception here
                Console.WriteLine("No elements in list");
            }
        }

	}

}