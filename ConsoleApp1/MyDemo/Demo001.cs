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
            //demoSyncWork();
            //demoAction();
            demoFunc();
            Console.ReadKey();
        }

        private int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread  {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return x + y;
        }

        private int Sum(int x, int y)
        {
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

        private void demoAction()
        {
            Action<string, int> actionTarget = new Action<string, int>(displayMsg);
            actionTarget.Invoke("Hello----", 999);
            //actionTarget.BeginInvoke("Hello----", 999,null,null);
        }

        private void demoFunc()
        {
            Func<int, int, int> b = new Func<int, int, int>(Add);
            int answer = b(10, 10);
            Console.WriteLine("========== {0} ===========", answer);
        }

        private void displayMsg(string msg, int count)
        {
            Console.WriteLine(" ++++++ {0} ++++++", "displayMsg start");
            Console.WriteLine("thread id : {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" ###### {0} --- {1} ######", msg, count);
            Console.WriteLine(" ++++++ {0} ++++++", "displayMsg end");
        }




    }
}
