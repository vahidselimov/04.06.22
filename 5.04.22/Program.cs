using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _5._04._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.Write(1);
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(0);
            //}
            #endregion
            #region 3
            //Task task = Task.Run(delegate ()
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Hello World");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("finshed");

            //});

            //Console.WriteLine("Vahid");

            //Console.WriteLine("Selimov");

            //task.Wait();

            //Console.WriteLine("Son");
            //Console.ReadLine();

            #endregion
            var task = get().ContinueWith (t=>{
                Console.WriteLine(t.Result);
            });
            

        }
        public static Task<string> get()
        {
            HttpClient http = new HttpClient();

            var task = Task.Run(delegate ()
            {
                return http.GetStringAsync("https://www.google.com");
            });
            return task;


        }



    }
    //public static void Write0()
    //{
    //    for (int i = 1; i < 100; i++)
    //    {
    //        Thread.Sleep(600);
    //        Console.Write(0);
    //    }
    //}
    //public static void Write1()
    //{
    //    for (int i = 0; i < 100; i++)
    //    {
    //        Thread.Sleep(900);
    //        Console.Write(1);
    //    }
    //}




}
