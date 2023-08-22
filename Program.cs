using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList lst = new System.Collections.ArrayList(capacity:25);
            Console.WriteLine(lst.Capacity);

            lst.Add(1);
            lst.Add(34);
            lst.Add(4.98F);
            lst.Add(true);
            lst.Add("Csharp");


            Console.WriteLine("----------------MyArrayList--------------------");
            MyArrayList myArrayList = new MyArrayList();
            Console.WriteLine(myArrayList.Count());

            myArrayList.Add(1);
            Console.WriteLine(myArrayList[1]);
            Console.WriteLine(myArrayList.Count());


            myArrayList.Add("Example");
            Console.WriteLine(myArrayList[2]);
            Console.WriteLine(myArrayList.Count());


            myArrayList.Add(2);
            Console.WriteLine(myArrayList[3]);
            Console.WriteLine(myArrayList.Count());


            myArrayList.Add(3);
            Console.WriteLine(myArrayList[4]);
            Console.WriteLine(myArrayList.Count());


            myArrayList.Add(4);
            Console.WriteLine(myArrayList[5]);
            Console.WriteLine(myArrayList.Count());


            myArrayList.Add(5);
            Console.WriteLine(myArrayList[6]);
            Console.WriteLine(myArrayList.Count());


            Console.WriteLine(myArrayList.Count());
            myArrayList.Add(6);
            Console.WriteLine(myArrayList[7]);



            myArrayList.Add("Example");
            Console.WriteLine(myArrayList.Count());
        }
    }
}
