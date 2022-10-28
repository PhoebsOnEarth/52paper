using System;
using System.Linq;
namespace SA52Paper
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //SectionA
            Console.WriteLine("Please type an ISBN number to check, use ? for missing digit.");
            string queryISBN = SectionA.InputISBNForQuery();
            if (string.IsNullOrEmpty(queryISBN))
            {
                Console.WriteLine("You have typed a wrong ISBN number, please only use digits and one '?");
                Console.ReadLine();
                return;
            }
            
            int missingIndex = SectionA.GetMissingIndex(queryISBN);
            Console.WriteLine(missingIndex);
            int othersWeightedSum = SectionA.GetOthersWeightedSum(queryISBN);
            Console.WriteLine(othersWeightedSum);
            int checkDigit = SectionA.GetIntFromCharDigit(queryISBN[12]);
            int missingDigit = SectionA.FindMissingDigit(othersWeightedSum, missingIndex, checkDigit);
            string message = ("This is the complete ISBN number: \n" + queryISBN).Replace("?", missingDigit.ToString());
            Console.WriteLine(message);
            Console.WriteLine("\nType any key to exit.");
            Console.ReadKey();
            */
            //SectionC
            
            Time12 t1 = new Time12(1);
            Time12 t2 = new Time12(1, 2);
            Time12 t3 = new Time12(1, 2, 3);
            Time12 t4 = new Time12(1, 2, 3, false);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            t1.DisplayTime24();
            t2.DisplayTime24();
            t3.DisplayTime24();
            t4.DisplayTime24();
            Time12TZ t5 = new Time12TZ(1);
            Time12TZ t6 = new Time12TZ(1,2);
            Time12TZ t7 = new Time12TZ(1, 2, 3);
            Time12TZ t8 = new Time12TZ(1, 2, 3, false);
            Time12TZ t9 = new Time12TZ(1, 2, 3, false, 888);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            t9.DisplayTime24();
            /*

            List<InterfaceA> list1 = new List<InterfaceA>();
            list1.Add(new A());
            list1.Add(new B());
            list1.Add(new B());
            //list1.Add(new E());
            foreach(InterfaceA obj in list1)
            {
                obj.MethodA();
            }
            Console.WriteLine();

            List<InterfaceB> list2 = new List<InterfaceB>();
            list2.Add(new B());
            list2.Add(new D());
            //list1.Add(new A());
            foreach (InterfaceB obj in list2)
            {
                obj.MethodB();
            }
            Console.WriteLine();

            List<InterfaceC> list3 = new List<InterfaceC>();
            list3.Add(new D());
            list3.Add(new D());
            //list1.Add(new C());
            foreach (InterfaceC obj in list3)
            {
                obj.MethodC();
            }
            */

        }  
    }
}

