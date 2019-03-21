using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conn1 = Connection.GetInstance();
            Connection conn2 = Connection.GetInstance();

            if(conn1 == conn2) {
                Console.WriteLine("conn1 and conn2 are the same");
            } else {
                Console.WriteLine("Diferent");
            }

            Console.WriteLine("Connection 1: {0}", conn1.Status());
            Console.WriteLine("Connection 2: {0}", conn2.Status());

            Console.ReadKey(true);
        }
    }
}
