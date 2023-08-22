using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class MyArrayList
    {
        private object[] myArray { get; set; }
        private int index = 0;
        public object this[int i]
        {
            get => myArray[i];
            set => myArray[i] = value;
        }
        public MyArrayList()
        {
            myArray = new object[5];
        }

        public MyArrayList(int count)
        {
            myArray = new object[count];
        }

        public void Add(object value)
        {
            int newLenth = myArray.Length * 2;
            CheckLengthOfArray();
            myArray[index] = value;
            index++;
        }

        public void CheckLengthOfArray()
        {
            object[] arraySize = myArray;
            if (index == (myArray.Length - 1))
            {
                Array.Resize(ref arraySize, (myArray.Length * 2));
            }
            myArray = arraySize;
        }

        /// <summary>
        /// Delete Last Item
        /// </summary>
        public void Remove()
        {
            var x = myArray.Last();
            myArray = myArray.Where(a => a != x).ToArray();
        }


        /// <summary>
        /// Delete with Index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            myArray = myArray.Where(a => a != myArray[index]).ToArray();
        }

        /// <summary>
        /// Delete with item
        /// </summary>
        /// <param name="index"></param>
        public void Remove(object value)
        {
            myArray = myArray.Where(a => a != value).ToArray();
        }


        /// <summary>
        /// Reverse ArrayList
        /// </summary>
        public void Reverse()
        {
            myArray.Reverse();
        }


        public int Count()
        {
            return myArray.Length;
        }

        public int GetIndexOfItem(object item)
        {
            int ind = 1;
            for (int i = 0; i <= myArray.Length -1; i++)
            {
                if (myArray[i] == item)
                {
                    ind = i;
                }
            }
            return ind;
        }
    }
}
