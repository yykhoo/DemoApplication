using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            /*            string test = "HI";
                        int[] num = new int[3];
                        num[0] = 100;
                        num[1] = 200;
                        num[2] = 300;

                        Console.WriteLine(test + num[0]  + '\n' + num[2] );

                        Console.WriteLine(test + num[2]);

                        Console.ReadKey();*/

            Guru99Tutorial pTutor = new Guru99Tutorial();
            //pTutor.callTutorial(1, ".NET");
            pTutor.RenameTutorial("Guru Tutorial");
            Console.WriteLine("Guru Tutorial class");
            Console.WriteLine( pTutor.GetTutorialName() + '\n' );

            pTutor.Set();
            Console.WriteLine(pTutor.GetTutorialName() + '\n');

            /*Console.WriteLine("Main Tutorial class");
            Tutorial mainTutor = new Tutorial();
            mainTutor.SetTutorial(1, "test1");
            Console.WriteLine(mainTutor.GetTutorialID());
            Console.WriteLine(mainTutor.GetTutorialName());

            mainTutor.SetTutorial("test2");
            Console.WriteLine(mainTutor.GetTutorialID());
            Console.WriteLine(mainTutor.GetTutorialName());*/

            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("test1");
            a1.Add(true);

            Console.WriteLine("a1.Count :" + a1.Count);
            Console.WriteLine("a1.Contains(2): " + a1.Contains(2));
            Console.WriteLine("Before remove a1.RemoveAt(1) a1[1]: " + a1[1]);
            a1.RemoveAt(1);
            Console.WriteLine("After remove a1.RemoveAt(1)  a1[1]: " + a1[1]);

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Pop();

            foreach( Object obj in st)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n\n\n--------------------STACK START----------------------");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("The number of elements in the stack = " + st.Count);
            Console.WriteLine("Does the stack contain the element 3 = " + st.Contains(3) );
            Console.WriteLine("--------------------STACK END----------------------");

            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            qt.Dequeue();

            Console.WriteLine("\n\n\n--------------------QUEUE START----------------------");
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("The number of elements in the queue = " + qt.Count);
            Console.WriteLine("Does the queue contain the element 3 = " + qt.Contains(3));
            Console.WriteLine("--------------------QUEUE END----------------------");

            Console.WriteLine("\n\n\n--------------------HASHTABLE START----------------------");
            Hashtable ht = new Hashtable();
            ht.Add("001", ".NET");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.NET");

            ICollection keys = ht.Keys;
            foreach( String k in keys)
            {
                Console.WriteLine(ht[k]);
            }

            Console.WriteLine("--------------------HASHTABLE START----------------------");


            Console.WriteLine("\n\n\n--------------------**** START----------------------");
            pTutor.displayChristmasTree(7);
            Console.WriteLine(); Console.WriteLine();
            pTutor.displayDiamond(7);
            Console.WriteLine("--------------------**** END----------------------");
            Console.ReadKey();



        }
    }
}
