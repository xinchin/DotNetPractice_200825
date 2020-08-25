using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.MyDemo
{

    /// <summary>
    /// 委托(delegate) 
    /// </summary>
    class Demo001
    {

        public delegate int BinaryOp(int x, int y);

        public void run()
        {
            //demoAsyncWork();
            demoSyncWork();
            Console.ReadKey();
        }


        private int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread  {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return x + y;
        }

        private int Sum(int x, int y) {
            Console.WriteLine("Sum() invoked on thread  {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return x + y;
        }

        /// <summary>
        /// 同步工作
        /// </summary>
        private void demoSyncWork()
        {
            Console.WriteLine(" ... Hello World ...");
            BinaryOp b = new BinaryOp(Add);
            b += Sum;

            foreach (Delegate item in b.GetInvocationList())
            {
                Console.WriteLine("Method Name : {0}", item.Method);
                Console.WriteLine("Type Name : {0}", item.Target);
            }

            Console.WriteLine("****** Synch Delegate Review ******");
            Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            //int answer = b(10, 10);
            int answer = b.Invoke(10, 10);

            Console.WriteLine("Doing more work in Main()");
            Console.WriteLine("10 + 10 is {0}", answer);
        }

        /// <summary>
        /// 非同步工作
        /// </summary>
        void demoAsyncWork()
        {
            BinaryOp b = new BinaryOp(Add);

            Console.WriteLine(" ... Hello World ...");
            Console.WriteLine("****** Synch Delegate Review ******");
            Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            IAsyncResult ar = b.BeginInvoke(10, 10, null, null);
            

            Console.WriteLine("Doing more work in Main()");

            int answer = b.EndInvoke(ar);

            Console.WriteLine("10 + 10 is {0}", answer);
        }

        private void sayHello()
        {
            Console.WriteLine(".......Say Hello again......");
        }

    }
}
