using ShayTest;
using System.Collections.Generic;

class Program
{

    //PLEASE NOTICE: IN ORDER TO RUN TEST BLOCK ALL
    //YOU NEED TO DO IS UNCOMMENT RELEVANT PART

    static void Main()
    {

        //----------------------------------------
        /* Console.Write("BEGIN mission 1:\n");
         T1 t1 = new T1();
         Console.Write($"   Colors Array before: {string.Join(",", t1.colors_array)}");
         Console.Write($"\n Colors Array after: {string.Join(",", t1.SortByColor())}\n");
         Console.Write("mission 1 END\n\n");
         //
        
         */

        //--------------------------------------------


        //-----------------------------------------
        /* Console.Write("BEGIN mission 2:\n");
         T2 t2 = new T2();
         Console.Write($"   Day1:\n {string.Join(",", t2.Shuffle())}\n");
         const int Days = 7;
         for (int i = 0; i < Days; i++)    
         Console.Write($"   Day{i+2}:\n {string.Join(",", t2.Shuffle())} \n");
         Console.Write("mission 2 END\n");
         //
       
        */
        //------------------------------------------

        //---------------------------------------

        /*Console.Write("BEGIN mission 3:\n");
        Console.Write("Input: '{(a+b)*[c-d]}' \n");
        T3 t3 = new T3("{(a+b)*[c-d]}");
        Console.Write($"String Validation Result: {t3.Validate()} \n\n");
        Console.Write("Input: '(a|b)|}(c|d)|' \n");
        t3 = new T3("(a|b)|}(c|d)|");
        Console.Write($"String Validation Result: {t3.Validate()} \n");
        Console.Write("mission 3 END\n");*/
        //------------------------------------------


        //------------------------------------------
        /* Console.Write("BEGIN mission 4:\n");
         T4 t4 = new T4();
         Console.Write($" Dictionary Items:\n {t4.ToString()}\n");
         //get item by key
         int key = 6; 
         var item = t4.Get(key);
         Console.Write($"Get item by key '{key}'.");
        Console.Write($"[{key}]:{item}\n");
         //set item by key+ value
         int value = 1234;
         Console.Write($"Set item by key '{key}' to value '{value}.");
         t4.Set(key, value);
         Console.Write($"\n Dictionary Items To see Change for key '{key}:\n {t4.ToString()}\n");
         value = 5;
         Console.Write($"Set all  item by value '{value}'.");
         t4.SetAll(5);
         Console.Write($"\n Dictionary after SetAll:  {t4.ToString()}\n");

         Console.Write("mission 4 END\n");*/

        /*
         //----------------------------------------------------

                //-----------------------------------------------------------
                //notice that here i will get all list because we assuming that verify function
                //bring the results by some criteria
                //here is a simple demonstration

                Console.Write("BEGIN mission 5:\n");
                T5 t5 = new T5();
                Console.Write($" 5 Pepole:\n {string.Join(",", t5.FindFive())}\n");
                Console.Write("mission 5 END\n");*/
        //------------------------------------------------------------------

    }
}
