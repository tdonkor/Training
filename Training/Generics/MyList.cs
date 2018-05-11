using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Generics
{
    class MyList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        //access the elements by implementing an indexor
        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                //should be validating this 
                this.items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }


        public MyList()
        {
            this.items = new T[2];
            this.capacity = 2;
            this.count = 0;

        }

        public void Add(T item)
        {
            //check if array runs out of space
            if (this.capacity == this.count)
            {
                //clone original array
                T[] clone = (T[])items.Clone();
                this.capacity *= 2;
                this.items = new T[this.capacity];

                //copy old array into the new array
                Array.Copy(clone, 0, this.items, 0, clone.Length);

            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public void Remove(T Item)
        {
            //check if array is not empty
            if (this.capacity == 1 )
            {
                // We can't remove items from an empty list
                throw new InvalidOperationException("Lists cannot be empty");

            }
        }

            //overload + operator
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> result = new MyList<T>();

            if (list1.count != list2.count)
            {
                // We can only add lists that are of the same size
                throw new InvalidOperationException("Lists are of different sizes!");
            }
            else
            {
                for (int i = 0; i < list1.count; i++)
                {
                    // list items need to be typecasted to dynamic
                    result.Add((dynamic)list1[i] + (dynamic)list2[i]);
                }
            }

            return result;
        }

        public override string ToString()
        {
            string tempString = string.Empty;

            for (int i = 0; i < this.count; i++)
            {
                if (i < this.count - 1)
                {
                    tempString += this.items[i] + ", ";
                }
                else
                {
                    tempString += this.items[i];
                }
            }

            return tempString;

            // Easy, but we also get all of the "empty" items
            //return string.Join(" ", this.items);
        }
    }
}
