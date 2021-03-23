using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
//Console.WriteLine("here you go");
           Console.WriteLine(Checknumber(25360));
            Console.WriteLine(calculatesum());
             fibunaccifunction(9);
            FibunacciFunction1(6 );
           // getfubinacci(10);
            getmyFibo(6);
            testArray();
testArrayList();
            Drawmyass();
             Drawmyass();
           Console.ReadLine();


        }

        public static void fibunaccifunction(int X)                       

            
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}",a,b);
             
            for (int i = 0; i < X; i++)
            {
                c = a + b;
                Console.Write(" {0} " , c);
            a = b;
            b = c;


        }
    
            
           
            //Console.Write(a +""+ b+ ""+ c+ "", {0}; {1}; {2})
        }
        public static void Drawmyass()
        {
            for (int i = 0; i < 10; i++)
            {
                // for (int j =0; j<20; i--)
                // {
                     Console.WriteLine("**");
                // }
                for (int j = 0; j <= i; j++)
                {
                    string a, b = string.Empty;
                    a = "*";
                    b += a;
                    Console.WriteLine("{0} {1}", a, b);
                  
                }
            
            }

        }


        public static void FibunacciFunction1(int X)

        {
            int a = 0, b, c;

            if (a == 0)
            {
                b = 1;
                c = 2;
                Console.WriteLine("{0} {1}  ", a, b);
                // Console.ReadLine();

                for (int i = 0; X >= i; i++)
                {
                    c = a + b;
                    Console.WriteLine("{0} ", c);
                    a = b;
                    b = c;
                    //  Console.WriteLine("{0} ", c);
                    //  Console.ReadLine();
                }


            }




        }




            public static void testArray()
            {
            string[] cars = { "this", "is", "good", "enough" };
            Array.Sort(cars);
            foreach(string car in cars)
            {

                Console.WriteLine(car);
            }

            }

        public static void testArrayList()
        {
            var arrlist = new ArrayList();
            arrlist.Add("this is new");
            arrlist.Add("tfou");
            arrlist.Add("a");
            arrlist.Add("aie");
            arrlist.Add("aie");
            arrlist.Sort();
            foreach (string i in arrlist)
            {
                Console.WriteLine(i);
            }
        }




        public static void getmyFibo(int X)
        {
            int a=0, b=0;

            if(a == 0)
                {
                b = 1;
                Console.WriteLine("{0} , {1}", a, b);            

            }
            for (int i =0; X>=i; i++)
            {
                int c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
            }



        }





















            
           
               

       
       

        public static double calculatesum() {

            // var objects = new object[] { "hfhf", 3.02, 100, 569.0151, 6.015, 5, "sdfkjsdf", true };
            var objectsint = new int[] { 3, 84, 4, 9494, 84947, 949, 9849 };
            var objectdouble = new double[] { 2.0, 8.025, 85.565, 949.684 };

            var objects = new object[] { 20.02, "cfgg", 54, 8462, 0.25, 954, 2.60, 64 };
            double sum = 0.0;
            for (int a = 0; a <objects.Length; a++)
            {
                if (objects[a] is double)
                sum += (double)objects[a];

               
            };
            return sum;








            /*

            var objects1 = new Object[] { "df",5,54,5,54,55.201,55.2,54.654,564.32,54,354 };
            double sum1 = 0.0;
            
            for (int i=0; i<objects.Length; i++)
            {

                if (objects1[i] is double)
                {

                    sum1 += (double)objects1[i];
                }
                
            }
            return sum;
            */

        }

        public static int DigitSum (int i)
        //DigitsSum(5434) → 16
        
        {
            int sum = 0;

            var number = new int[i];


            return sum;
        }











        private static bool Checknumber(int i)
        {

            while (i > 0)
            {
                //if the rest of division by 10 is 3
                if (i % 10 == 3)
                {

                    return true;
                }
                i /= 10;

            }
            return false;

        }

        

    }
}
   