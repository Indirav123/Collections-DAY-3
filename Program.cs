//Task ARRAY LIST

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ArrayListExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var data = new ArrayList();   //arraylist collection
//            data.Add("elements");             // add element
//            data.Add(1);
//            data.Add(5);
//            data.Add(26);
//            data.Add(56.4);
//            data.Add(32);
//            data.Remove(5);              // remove element
//            foreach (object obj in data)   // iteration
//            {
//                Console.WriteLine(obj);
//                Console.ReadLine();
//            }
//        }
//    }
//}

//TASK 2 – List operation(It is a collection of System.Collections.Generic namespace.)
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var value = new list<string>();       // list collection
//            value.add("cricket");                       // add element
//            value.add("football");
//            value.add("volleyball");
//            value.add("hockey");
//            value.add("basketball");
//            value.add("tennis");
//            value.remove("football");              // remove element
//            value.remove("tennis");
//            value.insert(3, "badminton");         // insert element
//            foreach (string st in value)
//            {
//                console.writeline(st);
//                console.readline();
//            }
//        }
//    }
//}
//TASK 3: SORTED LIST
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var value = new SortedList<string, int>();            // sortedlist collection
//            value.Add("java", 3);                                               // add element
//            value.Add("javascript", 4);
//            value.Add("c-sharp", 5);
//            value.Add("dotnet", 25);
//            value.Add("python", 27);
//            value.Add("typescript", 57);
//            value.Clear();
//            foreach (var pair in value)
//            {
//                Console.WriteLine(pair);
//            }
//            Console.ReadLine();
//        }
//    }
//    TASK-6 – Stack
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var value = new Stack<int>();                          // stack collection
//            value.Push(10);                                                    // adding the element
//            value.Push(40);
//            value.Push(33);
//            value.Push(62);
//            value.Push(48);
//            value.Push(21);
//            value.Push(31);
//            Console.WriteLine(value.Pop());
//            Console.WriteLine(value.Peek());
//            Console.WriteLine();
//            foreach (int item in value)
//            {
//                Console.WriteLine(item);
//                Console.ReadLine();
//            }
//        }
//    }
//}
//}
//Task4:LINKEDLIST
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var value = new LinkedList<int>();             // linkedlist collection
//            value.AddLast(13);          // add element
//            value.AddLast(33);
//            value.AddLast(23);
//            value.AddLast(51);
//            value.AddLast(60);
//            value.AddFirst(4);
//            value.AddFirst(6);
//            LinkedListNode<int> node = value.Find(51);         // find the node
//            value.AddBefore(node, 40);
//            foreach (int num in value)
//            {
//                Console.WriteLine(num);
//                Console.ReadLine();
//            }
//        }
//    }
//}
//TASK 5:Dictionary
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var pair = new Dictionary<string, string>();           // dictionary collection
//            pair.Add("in", "India");                                                // add keys and values
//            pair.Add("af", "Africa");
//            pair.Add("us", "United States");
//            pair.Add("ja", "Japan");
//            pair.Add("ch", "China");
//            pair.Add("ca", "Canada");
//            Console.WriteLine("Keys present in the dictionary:");
//            var key = new List<string>(pair.Keys);
//            foreach (string k in key)
//            {
//                Console.WriteLine("{0}", k);
//            }
//            Console.WriteLine("Values present in the dictionary:");
//            var value = new List<string>(pair.Values);
//            foreach (string val in value)
//            {
//                Console.WriteLine("{0}", val);
//            }
//            Console.ReadLine();
//        }
//    }
//}
//JAGGEDARRAY 2D REPRESENTATION
//using System;
//namespace Program
//{
//    class Program
//    {
//        public void assign(int m, int n, int[,] arr)
//        {
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    arr[i, j] = i + j;

//                }

//            }
//        }

//        // Program to pass the 2D array to a function in C

//        public static void Main()
//        {
//            Program p = new Program();
//            int m = 5;
//            int n = 5;

//            int[,] arr = new int[m, n];

//            p.assign(m, n, arr);

//            // print 2D array
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(arr[i, j]);
//                }
//                Console.WriteLine("\n");
//            }
//        }
//    }
//}
//QUEUE
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var value = new Queue<string>();                // queue collection
//            value.Enqueue("Item 1");                               // add element
//            value.Enqueue("Item 2");
//            value.Enqueue("Item 3");
//            value.Enqueue("Item 4");
//            value.Enqueue("Item 5");
//            value.Enqueue("Item 6");
//            value.Enqueue("Item 7");
//            Console.WriteLine(value.Dequeue());
//            Console.WriteLine(value.Peek());
//            Console.WriteLine();
//            foreach (string num in value)
//            {
//                Console.WriteLine(num);
//                Console.ReadLine();
//            }
//        }
//    }
//}
//HASH TABLE
//using System;
//using System.Collections;

//namespace CollectionsApplication
//{

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("001", "Aakash");
//            ht.Add("002", "Aakass Elango");
//            ht.Add("003", "Riju");
//            ht.Add("004", "Vishal");
//            ht.Add("005", "Nevetha");
//            ht.Add("006", "Naveen");
//            ht.Add("007", "Lalith");

//            if (ht.ContainsValue("XYZ"))
//            {
//                Console.WriteLine("This student name is already in the list");
//            }
//            else
//            {
//                ht.Add("008", "XYZ");
//            }

//            // Get a collection of the keys.
//            //The ICollection interface in C# defines the size, enumerators, and synchronization methods for all nongeneric collections. 
//            //It is the base interface for classes in the System.Collections namespace.
//            ICollection key = ht.Keys;

//            foreach (string k in key)
//            {
//                Console.WriteLine(k + ": " + ht[k]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
//BIT ARRAY:
//using System;
//using System.Collections;

//namespace CollectionsApplication
//{

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            //creating two  bit arrays of size 8
//            BitArray ba1 = new BitArray(4);
//            BitArray ba2 = new BitArray(4);
//            byte[] a = { 0 };
//            byte[] b = { 15 };

//            //storing the values 0, and 15 into the bit arrays
//            ba1 = new BitArray(a);
//            ba2 = new BitArray(b);

//            //content of ba1
//            Console.WriteLine("Bit array ba1: 0");

//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write("{0} ", ba1[i]);
//            }
//            Console.WriteLine("----------------------------------------------------------------");

//            //content of ba2
//            Console.WriteLine("Bit array ba2: 15");

//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write("{0} ", ba2[i]);
//            }
//            Console.WriteLine("----------------------------------------------------------------");
//            BitArray ba3 = new BitArray(4);
//            ba3 = ba1.And(ba2);

//            //content of ba3
//            Console.WriteLine("Bit array ba3 after AND operation: 0");

//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write("{0} ", ba3[i]);
//            }
//            Console.WriteLine("----------------------------------------------------------------");
//            ba3 = ba1.Or(ba2);

//            //content of ba3
//            Console.WriteLine("Bit array ba3 after OR operation: 15");

//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write("{0} ", ba3[i]);
//            }
//            Console.WriteLine("----------------------------------------------------------------");

//            Console.ReadKey();
//        }
//    }
//}

