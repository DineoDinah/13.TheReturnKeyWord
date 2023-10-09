using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cube = 3;
            
            //calling a method with areturn type
            Console.WriteLine(cube);
            
            //this wont give anything to console
            

            //freezing the console
            Console.ReadLine();
        }
        //declare a method with a return type int

        static int cubes(int number) 
        { 
            int results =number * number * number;
            return results;
            
        }
    }
}
