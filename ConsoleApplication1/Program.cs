using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexte ctx = new Contexte();
            Response r = new Response { Content = "jhdsjfh" };
            ctx.Responses.Add(r);
            Console.WriteLine("fin");
            Console.ReadKey();
        }
    }
}
