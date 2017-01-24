using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    
    class Program
    {
        delegate string Assignments();
        public string Check(string x)
        {
            string ans="no";
            while(ans !="Yes")
            {
                ans=Console.ReadLine();
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Assignments test = new Assignments();
            string input2 = test.Check("yes");
            Console.WriteLine(input2);
            
        }
    }
}
