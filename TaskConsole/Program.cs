using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks =
            {


                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #1");
                }),

                new Task(Tarefa),

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #2");
                }),
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #3");

                }) };
        }

            #region TASK1
            /* Task t1 = new Task(Tarefa);
            t1.Start();

            Task t2 =  Task.Run(Tarefa);

            Task.Run(Tarefa);

            Task.Factory.StartNew(Tarefa);

            Task.Run(() => 
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Tarefa do anônima");
                }
            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal")
       }*/
        #endregion


        

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do TASK");
            }
        }
    } 
}


          

