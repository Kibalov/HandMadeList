using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            myList.AddBegin("Start");
            for (int i = 0; i < 5; i++)
                myList.AddBegin(Convert.ToString(i));
            Console.WriteLine(myList.ToString);

            for (int i = 5; i < 10; i++)
                myList.AddEnd(Convert.ToString(i));
            Console.WriteLine(myList.ToString);

            myList.AddBefore("Here1", 9);
            Console.WriteLine(myList.ToString);
            myList.AddBefore("Here2", 0);
            Console.WriteLine(myList.ToString);

            myList.RemoveByIndex(20);
            Console.WriteLine(myList.ToString);
            myList.RemoveByIndex(0);
            Console.WriteLine(myList.ToString);

            foreach (string item in myList.GetAll())
            {
                Console.Write(item + "qq ");
            }
            Console.WriteLine();



            myList.Clear();
            Console.WriteLine(myList.ToString + " <- tut");
        }
    }
}
